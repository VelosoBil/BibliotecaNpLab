using BibliotecaNpLab.Data;
using BibliotecaNpLab.Models;
using BibliotecaNpLab.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaNpLab.Repositorios
{
    public class LivrosRepositorio : ILivrosRepositorio
    {
        private readonly BibliotecaDbContex _dbContex;
        public LivrosRepositorio(BibliotecaDbContex biblioteca)
        {
            _dbContex = biblioteca;
        }

        public async Task<List<LivrosModel>> ListarLivros()
        {
            return await _dbContex.Livros.ToListAsync();
        }

        public async Task<LivrosModel> BuscarId(int id)
        {
            return await _dbContex.Livros.FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<LivrosModel> Adicionar(LivrosModel livros)
        {
            await _dbContex.Livros.AddAsync(livros);
            await _dbContex.SaveChangesAsync();
            return livros;
        }

        public async Task<LivrosModel> Atualizar(LivrosModel livros, int id)
        {
            LivrosModel livroporid = await BuscarId(id);

            if (livroporid == null)
            {
                throw new Exception($"Livro para o ID:{id} não encontrado!");
            }

            livroporid.titulo = livros.titulo;
            livroporid.autor = livros.autor;
            livroporid.genero = livros.genero;
            livroporid.biografia = livros.biografia;
            livroporid.editora = livros.editora;
            _dbContex.Livros.Update(livroporid);
            await _dbContex.SaveChangesAsync();
            return livroporid;

        }

        public async Task<bool> Deletar(int id)
        {
            LivrosModel livroporid = await BuscarId(id);

            if (livroporid == null)
            {
                throw new Exception($"Livro para o ID:{id} não encontrado!");
            }

            _dbContex.Livros.Remove(livroporid);
            await _dbContex.SaveChangesAsync();
            return true;
        }
    }
}