using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Matricula.Modelos;
using Sistema_de_Matricula.Data;
using Sistema_de_Matricula.Servicos;

namespace Sistema_de_Matricula.Servicos
{
    public class CursoService : ICursoService
    {
        public void Add(Curso c)
        {
            CursoDAO dao = new CursoDAO();
            dao.Add(c);
        }

        public Curso Buscar(int id)
        {
            CursoDAO dao = new CursoDAO();
            return dao.Buscar(id);
        }

        public void Remover(int id)
        {
            CursoDAO dao = new CursoDAO();
            dao.Remover(id);
        }
    }
}
