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

            Retorno<Aluno> retorno = new(null);

            try
            {
                var aluno = _alunoApplication.BuscarAluno(id);

                if (aluno != null)
                {
                    retorno.CarregaRetorno(aluno, true, "Consulta realizada com sucesso!", 200);
                }
                else
                { 
                    retorno.CarregaRetorno(aluno, false, $"Aluno com o id {id} não foi encontrado", 204);
                }

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                retorno.CarregaRetorno(false, ex.Message, 400);
                return BadRequest(retorno);
            }
        }

        [HttpPost("InserirDadosAluno")]

        public IActionResult InserirDadosAluno([FromBody] Aluno aluno)
        {
            Retorno retorno = new();

            try
            {
                var mensagem = _alunoApplication.InserirAluno(aluno);
                retorno.CarregaRetorno(true, mensagem, 200);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                retorno.CarregaRetorno(false, ex.Message, 400);
                return BadRequest(aluno);
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
