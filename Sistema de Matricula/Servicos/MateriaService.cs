using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Matricula.Data;
using Models;

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

        public void Remover(int id)
        {
            MateriaDAO dao = new MateriaDAO();
            dao.Remover(id);
        }
    }
}
