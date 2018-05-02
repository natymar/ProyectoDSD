using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServicioProductos.Dominio;
using ServicioProductos.Errores;

namespace ServicioProductos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceProductos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceProductos.svc o ServiceProductos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceProductos : IServiceProductos
    {
        public Producto CrearProducto(Producto productoACrear)
        {
            using (TiendaWebEntities obj = new TiendaWebEntities())
            {
                obj.Productoes.Attach(productoACrear);
                obj.Productoes.Add(productoACrear);

                obj.SaveChanges();
            }
            return ObtenerProducto(productoACrear.idProducto);
        }

        public List<Producto> listarProductos()
        {
            TiendaWebEntities obj = new TiendaWebEntities();
            var producto = from a in obj.Productoes select a;
            return producto.ToList();
        }

        public Producto modificarProducto(Producto productoAModificar)
        {
            using (var db = new TiendaWebEntities())
            {
                var result = db.Productoes.SingleOrDefault(b => b.idProducto == productoAModificar.idProducto);
                if (result != null)
                {
                    result.marca = productoAModificar.marca;
                    result.nombre = productoAModificar.nombre;
                    result.precio = productoAModificar.precio;
                    result.cantidad = productoAModificar.cantidad;
                    result.estado = productoAModificar.estado;
                    db.SaveChanges();
                }
            }
            return ObtenerProducto(productoAModificar.idProducto);
        }

        public Producto ObtenerProducto(int id)
        {
            TiendaWebEntities prod = new TiendaWebEntities();
            var producto = (from p in prod.Productoes where p.idProducto == id select p).FirstOrDefault();

            return producto;
        }
    }
}
