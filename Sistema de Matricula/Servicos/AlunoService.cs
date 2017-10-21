using Sistema_de_Matricula.Models;
using Sistema_de_Matricula.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Sistema_de_Matricula.Servicos
{
   
    public class AlunoService : IAlunoService
    {
        public void Add(Aluno a)
        {
            AlunoDAO dao = new AlunoDAO();
            dao.Add(a);
        }

        public Aluno Buscar(string nome)
        {
            AlunoDAO dao = new AlunoDAO();
            return dao.Buscar(nome);
        }

        public List<Aluno> BuscarTodos()
        {
            AlunoDAO dao = new AlunoDAO();
            return dao.BuscarTodos();
        }

        public void Remover(string nome)
        {
            AlunoDAO dao = new AlunoDAO();
            dao.Remover(nome);
        }
    }
}
