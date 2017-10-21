
using Sistema_de_Matricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Matricula.DataEntity
{
    

    //TODO: PASSAR TODOS OS METODOS PARA ADO.NET 
    public class AlunoDAO
    {
        public void Add(Aluno a)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                 db.Alunos.Add(a);
                 db.SaveChanges();
                 db.Dispose();
            }

        }


        public Aluno Buscar(string nome)
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
             var res = db.Alunos.Where(a => a.Nome.Equals(nome)).FirstOrDefault();
             db.Dispose();
             return (Aluno)res;
            }

        }


        public IQueryable<Aluno> BuscarTodos()
        {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                IQueryable<Aluno> res = db.Alunos;
                db.Dispose();
                return res;
            }
        }

        public void Remover(string nome) {
            using (SistemaMatriculaContext db = new SistemaMatriculaContext())
            {
                var resultado = db.Alunos.Where(a => a.Nome.Equals(nome)).FirstOrDefault();
                db.Alunos.Remove((Aluno)resultado);
                db.SaveChanges();
                db.Dispose();
            }
        }

        //todo: atualizar

    }
}
