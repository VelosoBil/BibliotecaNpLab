using BibliotecaNpLab.Models;

namespace BibliotecaNpLab.Repositorios.Interfaces
{
    public interface ILivrosRepositorio
    {
        Task<List<LivrosModel>> ListarLivros();
        Task<LivrosModel> BuscarId(int id);
        Task<LivrosModel> Adicionar(LivrosModel livros);
        Task<LivrosModel> Atualizar(LivrosModel livros, int id);
        Task<bool> Deletar(int id);
    }
}
