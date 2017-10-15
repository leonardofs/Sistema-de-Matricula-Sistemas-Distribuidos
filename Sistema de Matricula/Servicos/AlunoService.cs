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
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "AlunoService" no arquivo de código e configuração ao mesmo tempo.
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

        public void Remover(string nome)
        {
            AlunoDAO dao = new AlunoDAO();
            dao.Remover(nome);
        }
    }
}
