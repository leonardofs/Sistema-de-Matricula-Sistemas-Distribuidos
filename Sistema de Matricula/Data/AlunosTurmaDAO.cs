using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Matricula.Models;

namespace Sistema_de_Matricula.Data
{
    public class AlunosTurmaDAO
    {

        private static ICollection<AlunosTurma> at = new List<AlunosTurma>();

        public void Add(AlunosTurma a)
        {
            at.Add(a);
        }

        // matriculaindividucal
        public AlunosTurma Buscar(int idAlu, int idTurma)
        {
            var res = at.FirstOrDefault(a => a.AlunoID.Equals(idAlu) && a.TurmaID.Equals(idTurma));
            return res;
        }

        public List<AlunosTurma> BuscarTodos(int idAlu)
        {
            return at.ToList();
        }

        public void Remover(int idAlu, int idTurma)
        {
            var res = at.FirstOrDefault(a => a.AlunoID.Equals(idAlu) && a.TurmaID.Equals(idTurma));
            at.Remove((AlunosTurma)res);
        }
    }
}
