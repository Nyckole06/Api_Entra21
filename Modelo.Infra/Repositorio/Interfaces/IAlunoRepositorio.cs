using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Domain;

namespace Modelo.Infra.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        Aluno BuscarId(int id);

        void InserirAluno(Aluno aluno);

        void ExcluirAluno(int id);

        void AlterarAluno(Aluno aluno);

        void EditarAluno(Aluno aluno);
    }
}
