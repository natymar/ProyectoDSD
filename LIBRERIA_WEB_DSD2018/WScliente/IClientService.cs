using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WScliente.Dominio;
using WScliente.Errores;

namespace WScliente
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IClientService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IClientService
    {
        
        [OperationContract]
        cliente ObtenerCliente(int idCliente);

        [OperationContract]
        List<cliente> ListarAllClientes();

        [FaultContract(typeof(DuplicadoException))]
        [OperationContract]
        List<cliente> BuscarCliente(string filtro);

        //agregamos una exception para un cliente duplicado
        [FaultContract(typeof(DuplicadoException))]
        [OperationContract]
        void CrearCliente(cliente c);

        [OperationContract]
        void ModificarCliente(cliente c);

        //[FaultContract(typeof(DuplicadoException))]
        
        [OperationContract]
        void EliminarCliente(int idcliente);


    }
}
