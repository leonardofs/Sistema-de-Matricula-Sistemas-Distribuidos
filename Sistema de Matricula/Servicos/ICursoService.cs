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
    public interface ICursoService
    {
        [OperationContract]
        void Add(Curso c);

        [OperationContract]
        Curso Buscar(int id);

        [OperationContract]
        List<Curso> BuscarTodos();


        [OperationContract]
        void Remover(int id);

        //todo atualizar
    }
}
