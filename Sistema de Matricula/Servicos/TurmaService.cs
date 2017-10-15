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
    public class TurmaService : ITurmaService
    {
        public void Add(Turma t)
        {
            TurmaDAO dao = new TurmaDAO();
            dao.Add(t);
        }

        public Turma Buscar(string nome)
        {
            TurmaDAO dao = new TurmaDAO();
            return dao.Buscar(nome);
        }

        public void Remover(string nome)
        {
            TurmaDAO dao = new TurmaDAO();
            dao.Remover(nome);
        }
    }
}
