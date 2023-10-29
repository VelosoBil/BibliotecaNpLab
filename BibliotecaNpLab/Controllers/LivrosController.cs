using BibliotecaNpLab.Models;
using BibliotecaNpLab.Repositorios;
using BibliotecaNpLab.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaNpLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly ILivrosRepositorio _livrosRepositorio;

        public LivrosController(ILivrosRepositorio livrosRepositorio)
        {
            _livrosRepositorio = livrosRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<LivrosModel>>> ListarLivros()
        {
            List<LivrosModel> livros = await _livrosRepositorio.ListarLivros();
            return (livros);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LivrosModel>> BuscarId(int id)
        {
            LivrosModel livros = await _livrosRepositorio.BuscarId(id);
            return (livros);

        }

        [HttpPost]
        public async Task<ActionResult<LivrosModel>> Adicionar([FromBody] LivrosModel livrosm)
        {
            LivrosModel livros = await _livrosRepositorio.Adicionar(livrosm);
            return (livros);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<LivrosModel>> Atualizar([FromBody] LivrosModel livrosm, int id)
        {
            livrosm.id = id;
            LivrosModel livros = await _livrosRepositorio.Atualizar(livrosm, id);
            return (livros);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<LivrosModel>> Deletar(int id)
        {
            bool deletado = await _livrosRepositorio.Deletar(id);
            return Ok(deletado);
        }
    }
}
