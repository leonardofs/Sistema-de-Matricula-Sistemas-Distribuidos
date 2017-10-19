using Sistema_de_Matricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Sistema_de_Matricula.Servicos
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IAlunoService" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IAlunoService
    {
        [OperationContract]
        void Add(Aluno a);

        [OperationContract]
        Aluno Buscar(string nome);

        [OperationContract]
        IQueryable<Aluno> BuscarTodos();

        [OperationContract]
        void Remover(string nome);

        //todo: atualizar

    }
}
