using Sistema_de_Matricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Matricula.Servicos
{   [ServiceContract]
    public interface ITurmaService
    {
        [OperationContract]
        void Add(Turma t);

        [OperationContract]
        Turma Buscar(string nome);

        [OperationContract]
        void Remover(string nome);

        //todo atualizar
    }
}
