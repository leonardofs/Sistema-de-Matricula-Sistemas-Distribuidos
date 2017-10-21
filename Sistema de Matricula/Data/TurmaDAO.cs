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
    public class TurmaDAO
    {
        private static List<Turma> turmas = new List<Turma>();

        public void Add(Turma t)
        {
            TurmaDAO.turmas.Add(t);
        }


        public Turma Buscar(string nome)
        {
            var resultado = TurmaDAO.turmas.Where(t => t.Nome.Equals(nome)).FirstOrDefault();
            return (Turma)resultado;
        }

        public List<Turma> BuscarTodos()
        {
            return turmas.ToList();
        }

        public void Remover(string nome)
        {
            var resultado = TurmaDAO.turmas.Where(t => t.Nome.Equals(nome)).FirstOrDefault();

            TurmaDAO.turmas.Remove((Turma)resultado);
        }
    }
}
