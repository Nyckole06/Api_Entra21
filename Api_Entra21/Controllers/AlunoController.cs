using Microsoft.AspNetCore.Mvc;
using Modelo.Domain;

namespace Api_Entra21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : Controller
    {
        [HttpGet("BuscarDadosAlunos/{id}")]
        public IActionResult BuscarDadosAluno(int id)
        {
            try
            {
                Aluno aluno = new Aluno();
                aluno.Id = 1;
                aluno.Nome = "João da Silva";
                aluno.Idade = 20;
                aluno.Cep = "12345-678";

                return Ok(aluno);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao buscar dados do aluno.");
            }
        }
    }
}
