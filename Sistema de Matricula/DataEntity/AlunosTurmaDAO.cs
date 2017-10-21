using Sistema_de_Matricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Matricula.DataEntity
{
    public class AlunosTurmaDAO
    {
        public void Add(AlunosTurma a)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                db.Sala.Add(a);
                db.SaveChanges();
                db.Dispose();
            }

        }

        // matriculaindividucal
        public AlunosTurma Buscar(int idAlu,int idTurma)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                var res = db.Sala.FirstOrDefault(a => a.AlunoID.Equals(idAlu) && a.TurmaID.Equals(idTurma));
                db.Dispose();
                return (AlunosTurma)res;
            }

        }

        public IQueryable<AlunosTurma> BuscarTodos(int idAlu)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                IQueryable<AlunosTurma> res = db.Sala.Where(a => a.AlunoID.Equals(idAlu) );
                db.Dispose();
                return res;
            }
        }



        public void Remover(int idAlu, int idTurma)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                var res = db.Sala.FirstOrDefault(a => a.AlunoID.Equals(idAlu) && a.TurmaID.Equals(idTurma));
                db.Sala.Remove((AlunosTurma)res);
                db.SaveChanges();
                db.Dispose();
            }
        }

        //todo: atualizar
    }
}
