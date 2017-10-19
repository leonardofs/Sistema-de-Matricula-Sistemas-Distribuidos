using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Matricula.Data;
using Sistema_de_Matricula.Models;

namespace Sistema_de_Matricula.Servicos
{
    public class MateriaService : IMateriaService
    {
        public object MateriaDao { get; private set; }

        public void Add(Materia m)
        {
            MateriaDAO dao = new MateriaDAO();
            dao.Add(m);
        }

        public Materia Buscar(int id)
        {
            MateriaDAO dao = new MateriaDAO();
            return dao.Buscar(id);
        }

        public IQueryable<Materia> BuscarTodos()
        {
            MateriaDAO dao = new MateriaDAO();
            return dao.BuscarTodos();
        }

        public void Remover(int id)
        {
            MateriaDAO dao = new MateriaDAO();
            dao.Remover(id);
        }
    }
}
