using Sistema_de_Matricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Matricula.DataEntity
{
    public class CursoDAO
    //TODO: PASSAR TODOS OS METODOS PARA ADO.NET 
    {

        public void Add(Curso c)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                db.Cursos.Add(c);
                db.SaveChanges();
                db.Dispose();
            }
        }

        public Curso Buscar(int id)
        {

            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                var res = db.Cursos.Where(a => a.ID.Equals(id)).FirstOrDefault();
                db.Dispose();
                return (Curso)res;
            }
        }

        public IQueryable<Curso> BuscarTodos()
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                IQueryable<Curso> res = db.Cursos;
                db.Dispose();
                return res;
            }
        }

        public void Remover(int id)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                var resultado = db.Cursos.Where(a => a.ID.Equals(id)).FirstOrDefault();
                db.Cursos.Remove((Curso)resultado);
                db.SaveChanges();
                db.Dispose();



            }
        }
    }
}
