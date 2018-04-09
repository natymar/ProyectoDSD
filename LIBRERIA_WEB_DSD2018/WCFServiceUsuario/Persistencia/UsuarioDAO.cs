using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFServiceUsuario.Dominio;

namespace WCFServiceUsuario.Persistencia
{
    public class UsuarioDAO
    {

        private string cadenaConexion = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=ventas;Integrated Security=SSPI";
        //Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
        public Usuario crear(Usuario usuarioACrear)
        {
            Usuario usuarioCreado = null;
            string sql = "INSERT INTO t_usuario VALUES (@codigoUsuario, @nombreUsuario, @apePaternoUsuario, @apeMaternoUsuario, @claveUsuario)";//añadi parentesis xd

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@codigoUsuario", usuarioACrear.codigoUsuario);
                    //comando.Parameters.Add(new SqlParameter("@codigoUsuario", usuarioACrear.codigoUsuario));
                    comando.Parameters.Add(new SqlParameter("@nombreUsuario", usuarioACrear.nombreUsuario));
                    comando.Parameters.Add(new SqlParameter("@apePaternoUsuario", usuarioACrear.apePaternoUsuario));
                    comando.Parameters.Add(new SqlParameter("@apeMaternoUsuario", usuarioACrear.apeMaternoUsuario));
                    comando.Parameters.Add(new SqlParameter("@claveUsuario", usuarioACrear.claveUsuario));
                    comando.ExecuteNonQuery();
                }

            }

            usuarioCreado = obtener(usuarioACrear.codigoUsuario);
            return usuarioCreado;
        }

        public Usuario obtener(int codigo)
        {
            Usuario usuarioEncontrado = null;
            string sql = "SELECT * FROM t_usuario where codigoUsuario = @codigoUsuario";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@codigoUsuario", codigo));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            usuarioEncontrado = new Usuario();
                            usuarioEncontrado.codigoUsuario = (int)resultado["codigoUsuario"];
                            usuarioEncontrado.nombreUsuario = (string)resultado["nombreUsuario"];
                            usuarioEncontrado.apePaternoUsuario = (string)resultado["apePaternoUsuario"];
                            usuarioEncontrado.apeMaternoUsuario = (string)resultado["apeMaternoUsuario"];
                        }

                    }


                }
                return usuarioEncontrado;
            }
        }

        public Usuario modificar(Usuario usuarioAModificar)
        {

            Usuario usuarioModificado = null;
            string sql = "UPDATE t_usuario SET  nombreUsuario=@nombreUsuario, apePaternoUsuario=@apePaternoUsuario, apeMaternoUsuario=@apeMaternoUsuario , claveUsuario= @claveUsuario " +
                            " WHERE codigoUsuario = @codigoUsuario";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@codigoUsuario", usuarioAModificar.codigoUsuario));
                    comando.Parameters.Add(new SqlParameter("@nombreUsuario", usuarioAModificar.nombreUsuario));
                    comando.Parameters.Add(new SqlParameter("@apePaternoUsuario", usuarioAModificar.apePaternoUsuario));
                    comando.Parameters.Add(new SqlParameter("@apeMaternoUsuario", usuarioAModificar.apeMaternoUsuario));
                    comando.Parameters.Add(new SqlParameter("@claveUsuario", usuarioAModificar.claveUsuario));
                    comando.ExecuteNonQuery();
                }

            }

            usuarioModificado = obtener(usuarioAModificar.codigoUsuario);
            return usuarioModificado;

        }

        public void eliminar(int codigo)
        {
            string sql = "DELETE FROM t_usuario WHERE  codigoUsuario = @codigoUsuario";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@codigoUsuario", codigo));
                    comando.ExecuteNonQuery();

                }

            }
        }

        public List<Usuario> listar()
        {

            List<Usuario> listaUsuarios = new List<Usuario>();


            Usuario usuarioEncontrado = null;
            string sql = "SELECT * FROM t_usuario";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            usuarioEncontrado = new Usuario();
                            usuarioEncontrado.codigoUsuario = (int)resultado["codigoUsuario"];
                            usuarioEncontrado.nombreUsuario = (string)resultado["nombreUsuario"];
                            usuarioEncontrado.apePaternoUsuario = (string)resultado["apePaternoUsuario"];
                            usuarioEncontrado.apeMaternoUsuario = (string)resultado["apeMaternoUsuario"];
                            listaUsuarios.Add(usuarioEncontrado);
                        }

                    }


                }
                return listaUsuarios;
            }

        }








        public int VerificarUsuario(string usuario, string clave)
        {
            int retorno=0;
            string sql = "SELECT * FROM t_usuario where codigoUsuario = @codigoUsuario and claveUsuario= @claveUsuario";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@codigoUsuario", usuario));
                    comando.Parameters.Add(new SqlParameter("@nombreUsuario", clave));
                    retorno = Convert.ToInt32(comando.ExecuteScalar());
                }

            }
            return retorno;
        }
    }
}