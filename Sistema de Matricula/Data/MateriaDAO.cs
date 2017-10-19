using Sistema_de_Matricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Matricula.Data
{
    //TODO: PASSAR TODOS OS METODOS PARA ADO.NET 
    public class MateriaDAO
    {
    

        public void Add(Materia m)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                db.Materias.Add(m);
                db.SaveChanges();
                db.Dispose();
            }
        }


        public Materia Buscar(int id)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                var res = db.Materias.Where(a => a.ID.Equals(id)).FirstOrDefault();
                db.Dispose();
                return (Materia)res;
            }
        }

        public IQueryable<Materia> BuscarTodos()
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                IQueryable<Materia> res = db.Materias;
                db.Dispose();
                return res;
            }
        }

        public void Remover(int id)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                var resultado = db.Materias.Where(a => a.ID.Equals(id)).FirstOrDefault();
                db.Materias.Remove((Materia)resultado);
                db.SaveChanges();
                db.Dispose();
            }
        }

        //todo atualizar
    }
}
