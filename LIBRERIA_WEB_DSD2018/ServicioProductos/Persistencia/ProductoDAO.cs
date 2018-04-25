using ServicioProductos.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServicioProductos.Persistencia
{
    public class ProductoDAO
    {
        private string conn = "Data Source=DESKTOP-G210HTM\\SQLEXPRESS;Initial Catalog=TiendaWeb; Integrated Security=SSPI;";

        public Producto CrearProducto(Producto productoACrear)
        {
            Producto productoCreado = null;
            string sql = "INSERT INTO Producto VALUES(@id, @marca, @nombre, @precio, @cantidad, @estado)";
            using (SqlConnection conexion = new SqlConnection(conn))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", productoACrear.idProducto));
                    comando.Parameters.Add(new SqlParameter("@marca", productoACrear.marca));
                    comando.Parameters.Add(new SqlParameter("@nombre", productoACrear.nombre));
                    comando.Parameters.Add(new SqlParameter("@precio", productoACrear.precio));
                    comando.Parameters.Add(new SqlParameter("@cantidad", productoACrear.cantidad));
                    comando.Parameters.Add(new SqlParameter("@estado", productoACrear.estado));
                    comando.ExecuteNonQuery();
                }
            }
            productoCreado = ObtenerProducto(productoACrear.idProducto);
            return productoCreado;
        }

        public Producto ObtenerProducto(int id)
        {
            Producto productoEncontrado = null;
            string sql = "SELECT * FROM Producto WHERE idProducto = @id";
            using (SqlConnection conexion = new SqlConnection(conn))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if(resultado.Read())
                        {
                            productoEncontrado = new Producto()
                            {
                                idProducto = (int)resultado["idProducto"],
                                marca = (string)resultado["marca"],
                                nombre = (string)resultado["nombre"],
                                precio = (decimal)resultado["precio"],
                                cantidad = (int)resultado["cantidad"],
                                estado = (string)resultado["estado"],
                            };
                        }
                    }
                }
            }
            return productoEncontrado;
        }

        public Producto modificarProducto(Producto productoAModificar)
        {
            Producto productoModificado = null;
            string sql = "UPDATE Producto SET marca=@marca, nombre=@nombre, precio=@precio, cantidad=@cantidad, estado=@estado WHERE idProducto=@id";
            using (SqlConnection conexion = new SqlConnection(conn))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", productoAModificar.idProducto));
                    comando.Parameters.Add(new SqlParameter("@marca", productoAModificar.marca));
                    comando.Parameters.Add(new SqlParameter("@nombre", productoAModificar.nombre));
                    comando.Parameters.Add(new SqlParameter("@precio", productoAModificar.precio));
                    comando.Parameters.Add(new SqlParameter("@cantidad", productoAModificar.cantidad));
                    comando.Parameters.Add(new SqlParameter("@estado", productoAModificar.estado));
                    comando.ExecuteNonQuery();
                }
            }
            productoModificado = ObtenerProducto(productoAModificar.idProducto);
            return productoModificado;
        }


    }
}