using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Matricula.Data
{
    //TODO: PASSAR TODOS OS METODOS PARA ADO.NET 
    public class ProfessorDAO
    {
        private static List<Professor> professores = new List<Professor>();

        public void Add(Professor p)
        {
            ProfessorDAO.professores.Add(p);
           
        }


        public Professor Buscar(string nome)
        {
            var resultado = ProfessorDAO.professores.Where(p => p.Nome.Equals(nome)).FirstOrDefault();
            return (Professor)resultado;
        }


        public void Remover(string nome)
        {
            var resultado = ProfessorDAO.professores.Where(p => p.Nome.Equals(nome)).FirstOrDefault();

             ProfessorDAO.professores.Remove((Professor)resultado);
        }
    }
}
