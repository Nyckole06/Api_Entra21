using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Domain;

namespace Modelo.Application.Interfaces
{
    public interface IAlunoApplication
    {
        Aluno BuscarAluno(int id);

        string InserirAluno(Aluno aluno);

        void ExcluirAluno(int id);

        void AlterarAluno(Aluno aluno);

        void EditarAluno(Aluno aluno);
    }
}
