using Sistema_de_Matricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Matricula.Data
{
    public class CursoDAO
    //TODO: PASSAR TODOS OS METODOS PARA ADO.NET 
    {
        private static List<Curso> cursos = new List<Curso>();
        public void Add(Curso c)
        {
            CursoDAO.cursos.Add(c);

        }


        public Curso Buscar(int id)
        {
            var resultado = CursoDAO.cursos.Where(c => c.ID.Equals(id)).FirstOrDefault();
            return (Curso)resultado;
        }

        public List<Curso> BuscarTodos()
        {
            return cursos.ToList();
        }



        public void Remover(int id)
        {
            var resultado = CursoDAO.cursos.Where(c => c.ID.Equals(id)).FirstOrDefault();

            CursoDAO.cursos.Remove((Curso)resultado);
        }
    }
}
