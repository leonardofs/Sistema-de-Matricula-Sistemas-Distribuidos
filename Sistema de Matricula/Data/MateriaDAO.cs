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
        private static List<Materia> materias = new List<Materia>();

        public void Add(Materia m)
        {
            MateriaDAO.materias.Add(m);
        }


        public Materia Buscar(int id)
        {
            var resultado = MateriaDAO.materias.Where(m => m.ID.Equals(id)).FirstOrDefault();
            return (Materia)resultado;
        }

        public List<Materia> BuscarTodos()
        {
            return materias.ToList();
        }



        public void Remover(int id)
        {
            var resultado = MateriaDAO.materias.Where(m => m.ID.Equals(id)).FirstOrDefault();
            MateriaDAO.materias.Remove((Materia)resultado);
        }

        //todo atualizar
    }
}
