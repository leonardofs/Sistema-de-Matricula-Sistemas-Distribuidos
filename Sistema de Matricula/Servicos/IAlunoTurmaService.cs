using Sistema_de_Matricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Matricula.Servicos
{
    [ServiceContract]
    public interface IAlunoTurmaService
    {
        [OperationContract]
        void Add(AlunosTurma a);

        [OperationContract]
        List<AlunosTurma> BuscarTodos(int idAluno);

        [OperationContract]
        AlunosTurma Buscar(int idAluno, int idTurma);

        [OperationContract]
        void Remover(int idAlu, int idTurma);

        //todo: atualizar

    }
}

