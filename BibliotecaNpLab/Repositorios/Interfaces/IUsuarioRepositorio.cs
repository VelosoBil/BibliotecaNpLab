using BibliotecaNpLab.Models;

namespace BibliotecaNpLab.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> ListarUser();
        Task<UsuarioModel> BuscarId(int id);
        Task<UsuarioModel>Adicionar(UsuarioModel usuario);
        Task<UsuarioModel>Atualizar(UsuarioModel usuario, int id);
        Task<bool> Deletar(int id);
    }
}
