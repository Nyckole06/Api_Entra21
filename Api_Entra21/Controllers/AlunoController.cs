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
            catch (Exception ex)
            {
                return BadRequest("Erro ao buscar dados do aluno.");
            }
        }

        [HttpPost("InserirDadosAluno")]

        public IActionResult InserirDadosAluno([FromBody] Aluno aluno)
        {
            try
            {
                _alunoApplication.InserirAluno(aluno);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("ExcluirDadosAluno/{id}")]

        public IActionResult ExcluirDadosAluno(int id)
        {
            try
            {
                _alunoApplication.ExcluirAluno(id);
                return Ok("Aluno excluído com sucesso!");
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPut("AlterarDadosAluno")]

        public IActionResult AlterarDadosAluno([FromBody] Aluno aluno)
        {
            try
            {
                _alunoApplication.AlterarAluno(aluno);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPatch("EditarDadosAluno")]

        public IActionResult EditarDadosAluno([FromBody] Aluno aluno)
        {
            try
            {
                _alunoApplication.EditarAluno(aluno);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }
    }
}
