using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WSPedido.Dominio;

namespace WSPedido.Persistencia
{
    public class PedidoDAO
    {
        private string CadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=TiendaWeb;Integrated Security=SSPI;";
        //para cambiar cadena de conexion
        public Pedido Crear(Pedido pedidoACrear)
        {
            Pedido pedidoCreado = null;
            string sql = "INSERT INTO Cotizacion (dniCliente, nombreCliente, correoCliente, rutafile, estado, fechaCreacion) VALUES (@dnicli, @nomcli, @correocli, @rutafile, @estado, @fechaped)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@dnicli", pedidoACrear.IdPedido));
                    comando.Parameters.Add(new SqlParameter("@nomcli", pedidoACrear.NombreCli));
                    comando.Parameters.Add(new SqlParameter("@correocli", pedidoACrear.CorreoCli));
                    comando.Parameters.Add(new SqlParameter("@rutafile", pedidoACrear.RutaFile));
                    comando.Parameters.Add(new SqlParameter("@estado", pedidoACrear.Estado));
                    comando.Parameters.Add(new SqlParameter("@fechaped", pedidoACrear.FechaPed));
                    comando.ExecuteNonQuery();
                }
            }
            return pedidoCreado;
        }

        public Pedido Obtener(int dni)
        {
            Pedido pedidoEncontrado = null;
            string sql = "SELECT * FROM Cotizacion WHERE dniCliente=@dni";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@dni", dni));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            pedidoEncontrado = new Pedido()
                            {
                                IdPedido = (int)resultado["idCotizacion"],
                                NombreCli = (string)resultado["nombreCliente"],
                                FechaPed = (DateTime)resultado["fechaCreacion"],
                                Estado = (string)resultado["estado"],
                                RutaFile = (string)resultado["rutafile"]
                            };
                        }
                    }
                }
            }
            return pedidoEncontrado;
        }

        public List<Pedido> Listar()
        {
            List<Pedido> pedidosEncontrados = new List<Pedido>();
            //Ped
            return null;
        }
    }
}