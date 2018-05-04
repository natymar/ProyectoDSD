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
        private string CadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=BDLibreria;Integrated Security=SSPI;";
        //para cambiar cadena de conexion
        public Pedido Crear(Pedido pedidoACrear)
        {
            Pedido pedidoCreado = null;
            string sql = "INSERT INTO t_pedido VALUES (@dnicli, @nomcli, @correocli, @archivo)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@dnicli", pedidoACrear.IdPedido));
                    comando.Parameters.Add(new SqlParameter("@nomcli", pedidoACrear.NombreCli));
                    comando.Parameters.Add(new SqlParameter("@correocli", pedidoACrear.CorreoCli));
                    comando.Parameters.Add(new SqlParameter("@archivo", pedidoACrear.Archivo));
                    comando.Parameters.Add(new SqlParameter("@archivo", pedidoACrear.FechaPed));
                    comando.ExecuteNonQuery();
                }
            }
            return pedidoCreado;
        }

        public List<Pedido> Listar()
        {
            List<Pedido> pedidosEncontrados = new List<Pedido>();
            Ped
        }
    }
}