using Sistema_de_Matricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Matricula.DataEntity
{
    //TODO: PASSAR TODOS OS METODOS PARA ADO.NET 
    public class ProfessorDAO
    {
      

        public void Add(Professor p)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                db.Professores.Add(p);
                db.SaveChanges();
                db.Dispose();
            }

        }


        public Professor Buscar(string nome)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                var res = db.Professores.Where(a => a.Nome.Equals(nome)).FirstOrDefault();
                db.Dispose();
                return (Professor)res;
            }
        }


        public IQueryable<Professor> BuscarTodos()
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                IQueryable<Professor> res = db.Professores;
                db.Dispose();
                return res;
            }
        }



        public void Remover(string nome)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                var resultado = db.Professores.Where(a => a.Nome.Equals(nome)).FirstOrDefault();
                db.Professores.Remove((Professor)resultado);
                db.SaveChanges();
                db.Dispose();
            }
        }
    }
}
