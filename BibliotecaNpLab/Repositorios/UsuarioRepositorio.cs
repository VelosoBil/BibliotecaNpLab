using BibliotecaNpLab.Data;
using BibliotecaNpLab.Models;
using BibliotecaNpLab.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaNpLab.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private readonly BibliotecaDbContex _dbContex;
        public UsuarioRepositorio(BibliotecaDbContex biblioteca) 
        {
            _dbContex = biblioteca;
        }
        public async Task<List<UsuarioModel>> ListarUser()
        {
            return await _dbContex.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> BuscarId (int id)
        {
            return await _dbContex.Usuarios.FirstOrDefaultAsync(x => x.id == id);
        }
        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioporid = await BuscarId(id);
            
            if (usuarioporid == null) 
            {
                throw new Exception($"Usuario para o ID:{id} não encontrado!");
            }

            usuarioporid.nome = usuario.nome;
            usuarioporid.endereco = usuario.endereco;
            usuarioporid.bairro = usuario.bairro;
            usuarioporid.cep = usuario.cep;
            usuarioporid.cidade = usuario.cidade;
            usuarioporid.uf = usuario.uf;
            usuarioporid.celular = usuario.celular;
            usuarioporid.login = usuario.login;
            usuarioporid.senha = usuario.senha;
            usuarioporid.generosfav = usuario.generosfav;
            usuarioporid.autoresfav = usuario.autoresfav;
            _dbContex.Usuarios.Update(usuarioporid);
            await _dbContex.SaveChangesAsync();
            return usuarioporid;

        }
        public async Task<UsuarioModel> Adicionar (UsuarioModel usuario)
        {
            await _dbContex.Usuarios.AddAsync(usuario);
            await _dbContex.SaveChangesAsync();
            return usuario; 
        }
        public async Task<bool> Deletar(int id)
        {
            UsuarioModel usuarioporid = await BuscarId(id);

            if (usuarioporid == null)
            {
                throw new Exception($"Usuario para o ID:{id} não encontrado!");
            }

            _dbContex.Usuarios.Remove(usuarioporid);
            await _dbContex.SaveChangesAsync();
            return true;
        }
    }
}
