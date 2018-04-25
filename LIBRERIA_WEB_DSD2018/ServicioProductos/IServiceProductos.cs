using ServicioProductos.Dominio;
using ServicioProductos.Errores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioProductos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceProductos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceProductos
    {
        [FaultContract(typeof(ProductoRepetido))]
        [OperationContract]
        Producto CrearProducto(Producto productoACrear);
        [OperationContract]
        Producto ObtenerProducto(int id);
        [OperationContract]
        Producto modificarProducto(Producto productoAModificar);
        [OperationContract]
        List<Producto> listarProductos();
    }
}
