using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WSPedido.Dominio;

namespace WSPedido
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPedidos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPedidos
    {
        [OperationContract]
        Pedido CrearPedido(Pedido pedidoACrear);

        [OperationContract]
        Pedido ObtenerPedido(int dni);

        [OperationContract]
        List<Pedido> ListarPedidos();
    }
}
