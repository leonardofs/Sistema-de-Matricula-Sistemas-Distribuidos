
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
    public class AlunoDAO
    {
        private static List<Aluno> alunos = new List<Aluno>();

        public void Add(Aluno a)
        {
            AlunoDAO.alunos.Add(a);  
        }

        public Aluno Buscar(string nome)
        {
            var resultado = AlunoDAO.alunos.Where(a => a.Nome.Equals(nome)).FirstOrDefault();
            return (Aluno)resultado;
        }

        public List<Aluno> BuscarTodos()
        {
            return alunos.ToList();
        }


        public void Remover(string nome) {
            var resultado = AlunoDAO.alunos.Where(a => a.Nome.Equals(nome)).FirstOrDefault();

            AlunoDAO.alunos.Remove((Aluno)resultado);
        }

        //todo: atualizar

    }
}
