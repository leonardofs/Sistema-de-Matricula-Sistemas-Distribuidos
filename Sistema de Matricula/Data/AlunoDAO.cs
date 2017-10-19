
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
        public void Add(Aluno a)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                 db.Alunos.AddAsync(a);
                 db.SaveChanges();
            }

        }


        public Aluno Buscar(string nome)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
             var res = db.Alunos.Where(a => a.Nome.Equals(nome)).FirstOrDefault();
            return (Aluno)res;
            }

        }


        public void Remover(string nome) {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                var resultado = db.Alunos.Where(a => a.Nome.Equals(nome)).FirstOrDefault();
                db.Alunos.Remove((Aluno)resultado);
                db.SaveChanges();
            }
        }

        //todo: atualizar

    }
}
