using BibliotecaNpLab.Models;
using BibliotecaNpLab.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaNpLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> ListarUser()
        {
            List<UsuarioModel> usuarios = await _usuarioRepositorio.ListarUser();
            return (usuarios);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> BuscarId(int id)
        {
            UsuarioModel usuarios = await _usuarioRepositorio.BuscarId(id);
            return (usuarios);

        }

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Adicionar([FromBody] UsuarioModel usuariom)
        {
            UsuarioModel usuario = await _usuarioRepositorio.Adicionar(usuariom);
            return (usuario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UsuarioModel>> Atualizar([FromBody] UsuarioModel usuariom, int id)
        {
            usuariom.id = id;
            UsuarioModel usuario = await _usuarioRepositorio.Atualizar(usuariom,id);
            return (usuario);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UsuarioModel>> Deletar(int id)
        {
            bool deletado = await _usuarioRepositorio.Deletar(id);
            return Ok(deletado);
        }
    }
}
