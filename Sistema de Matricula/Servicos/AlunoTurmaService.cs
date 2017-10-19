using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Matricula.Models;
using Sistema_de_Matricula.Data;

namespace Sistema_de_Matricula.Servicos
{
    public class AlunoTurmaService : IAlunoTurmaService
    {
        public void Add(AlunosTurma a)
        {
            AlunosTurmaDAO dao = new AlunosTurmaDAO();
            dao.Add(a);
        }



        public AlunosTurma Buscar(int idAluno, int idTurma)
        {
            AlunosTurmaDAO dao = new AlunosTurmaDAO();
            return dao.Buscar(idAluno, idTurma);
        }

        public IQueryable<AlunosTurma> BuscarTodos(int idAluno)
        {
            AlunosTurmaDAO dao = new AlunosTurmaDAO();
            return dao.BuscarTodos(idAluno);
        }

        public void Remover(int idAlu, int idTurma)
        {
            AlunosTurmaDAO dao = new AlunosTurmaDAO();

            dao.Remover(idAlu, idTurma);
        }
    }
}
