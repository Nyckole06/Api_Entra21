using Microsoft.AspNetCore.Mvc;
using Modelo.Application.Interfaces;
using Modelo.Domain;

namespace Api_Entra21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : Controller
    {
        private readonly IAlunoApplication _alunoApplication;

        public AlunoController(IAlunoApplication alunoApplication)
        {
            _alunoApplication = alunoApplication;
        }

        [HttpGet("BuscarDadosAlunos/{id}")]
        public IActionResult BuscarDadosAluno(int id)
        {
            try
            {
                return Ok(_alunoApplication.BuscarAluno(id));
            }
            catch (Exception)
            {
                return BadRequest("Erro ao buscar dados do aluno.");
            }
        }
    }
}
