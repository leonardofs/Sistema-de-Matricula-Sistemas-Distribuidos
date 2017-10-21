using Sistema_de_Matricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Matricula.DataEntity
{
   
    public class TurmaDAO
    {
        

        public void Add(Turma t)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                db.Turmas.Add(t);
                db.SaveChanges();
                db.Dispose();
            }
        }


        public Turma Buscar(string nome)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                var res = db.Turmas.Where(a => a.Nome.Equals(nome)).FirstOrDefault();
                db.Dispose();
                return (Turma)res;
            }
        }


        public IQueryable<Turma> BuscarTodos()
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                IQueryable<Turma> res = db.Turmas;
                db.Dispose();
                return res;
            }
        }

        public void Remover(string nome)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                var resultado = db.Turmas.Where(a => a.Nome.Equals(nome)).FirstOrDefault();
                db.Turmas.Remove((Turma)resultado);
                db.SaveChanges();
                db.Dispose();
            }
        }
    }
}
