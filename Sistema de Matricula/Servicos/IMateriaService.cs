using Sistema_de_Matricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Matricula.Servicos
{   [ServiceContract]
    public interface IMateriaService
    {
        [OperationContract]
        void Add(Materia m);

        [OperationContract]
        Materia Buscar(int id);

        [OperationContract]
        List<Materia> BuscarTodos();

        [OperationContract]
        void Remover(int id);

        //todo atualizar
    }
}
