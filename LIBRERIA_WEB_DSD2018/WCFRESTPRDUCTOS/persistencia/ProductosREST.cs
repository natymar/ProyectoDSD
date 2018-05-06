using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFRESTPRDUCTOS.dominio;

namespace WCFRESTPRDUCTOS.persistencia
{
    public class ProductosREST
    {
        private string CadenaConexion = "data source=ELIZABETH-HP;initial Catalog=BDLibreria;Integrated Security=SSPI;";

        public productoRest Crear(productoRest productoACrear)
        {
            productoRest productoCreado = null;
            string sql = "insert into t_productos values(@id,@marca,@nombre,@precio,@cantidad,@estado)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", productoACrear.idproducto));
                    comando.Parameters.Add(new SqlParameter("@marca", productoACrear.marca));
                    comando.Parameters.Add(new SqlParameter("@nombre", productoACrear.nombre));
                    comando.Parameters.Add(new SqlParameter("@precio", productoACrear.precio));
                    comando.Parameters.Add(new SqlParameter("@cantidad", productoACrear.cantidad));
                    comando.Parameters.Add(new SqlParameter("@estado", productoACrear.estado));
                    comando.ExecuteNonQuery();
                }
            }
            productoCreado = Obtener(productoACrear.idproducto);
            return productoCreado;
        }

        public productoRest Obtener(int id)
        {
            productoRest productoEncontrado = null;
            string sql = "select * from t_productos where id=@id";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {

                        if (resultado.Read() == true)
                        {
                            productoEncontrado = new productoRest()
                            {
                                idproducto = (int)resultado["id"],
                                marca = (string)resultado["marca"],
                                nombre = (string)resultado["nombre"],
                                precio = Convert.ToDouble(resultado["precio"]),
                                cantidad = (int)resultado["cantidad"],
                                estado = (string)resultado["estado"]
                            };
                        }
                    }

                }
            }

            return productoEncontrado;
        }

        public productoRest Modificar(productoRest productoAModificar)
        {
            productoRest productoModificado = null;
            string sql = "update t_productos set marca=@marca, nombre=@nombre, precio=@precio, cantidad=@cantidad, estado=@estado where id=@id";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", productoAModificar.idproducto));
                    comando.Parameters.Add(new SqlParameter("@marca", productoAModificar.marca));
                    comando.Parameters.Add(new SqlParameter("@nombre", productoAModificar.nombre));
                    comando.Parameters.Add(new SqlParameter("@precio", productoAModificar.precio));
                    comando.Parameters.Add(new SqlParameter("@cantidad", productoAModificar.cantidad));
                    comando.Parameters.Add(new SqlParameter("@estado", productoAModificar.estado));
                    comando.ExecuteNonQuery();
                }
            }
            productoModificado = Obtener(productoAModificar.idproducto);
            return productoModificado;
        }

        public void Eliminar(int id)
        {
            string sql = "delete t_productos where id=@id";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", id));
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<productoRest> Listar()
        {
            List<productoRest> productosEcontrados = new List<productoRest>();
            productoRest productoEncontrado = null;
            string sql = "select * from t_productos";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            productoEncontrado = new productoRest()
                            {

                                idproducto = (int)resultado["id"],
                                marca = (string)resultado["marca"],
                                nombre = (string)resultado["nombre"],
                                precio = Convert.ToDouble(resultado["precio"]),
                                cantidad = (int)resultado["cantidad"],
                                estado = (string)resultado["estado"]
                            };
                            productosEcontrados.Add(productoEncontrado);
                        }
                    }
                }
            }
            return productosEcontrados;
        }
    }
}