using Sistema_de_Matricula.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Matricula.Data;
using Sistema_de_Matricula.Models;

namespace Sistema_de_Matricula.Servicos
{
    public class ProfessorService : IProfessorService

    {
        public void Add(Professor p)
        {
            ProfessorDAO dao = new ProfessorDAO();
            dao.Add(p);
        }

        public Professor Buscar(string nome)
        {
            ProfessorDAO dao = new ProfessorDAO();
            return dao.Buscar(nome);
        }

        public void Remover(string nome)
        {
            ProfessorDAO dao = new ProfessorDAO();
            dao.Remover(nome);
        }
    }
}
