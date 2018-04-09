using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WScliente.Dominio;

namespace WScliente.Persistencia
{
    public class ClienteDAO
    {
        public cliente ObtenerCliente(int idcliente)
        {//ObtenerFactura
            cliente ClienteEncontrado = null;
            using (SqlConnection cn = new SqlConnection(ConexionDAO.getConexion()))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("ObtenerCliente", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@idCliente", idcliente));
                    using (SqlDataReader resultado = cmd.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            ClienteEncontrado = new cliente()
                            {
                                idCliente = (int)resultado["idCliente"],
                                nombre = (string)resultado["nombre"],
                                apePater = (string)resultado["apePater"],
                                apeMater= (string)resultado["apeMater"],
                                dni = (int)resultado["dni"],
                                correo = (string)resultado["correo"],
                                estado = (string)resultado["estado"]
                            };
                        }
                    }
                }
                return ClienteEncontrado;
            }
        }//obtener Cliente

        public List<cliente> ListarAllClientes()
        {
            List<cliente> ListaClientes = new List<cliente>();
            cliente cliente = null;
            using (SqlConnection cn = new SqlConnection(ConexionDAO.getConexion()))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("ListarAllClientes", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader resultado = cmd.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            cliente = new cliente()
                            {
                                idCliente = (int)resultado["idCliente"],
                                nombre = (string)resultado["nombre"],
                                apePater = (string)resultado["apePater"],
                                apeMater = (string)resultado["apeMater"],
                                dni = (int)resultado["dni"],
                                correo = (string)resultado["correo"],
                                estado = (string)resultado["estado"]
                            };
                            ListaClientes.Add(cliente);
                        }
                    }
                }
            }//sqlconecction
            return ListaClientes;
        } //listarAllClientes

        public List<cliente> BuscarCliente(string filtro)
        {
            List<cliente> ListaClientes = new List<cliente>();
            cliente cliente = null;
            using (SqlConnection cn = new SqlConnection(ConexionDAO.getConexion()))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("BuscarCliente", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@filtro", filtro));
                    using (SqlDataReader resultado = cmd.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            cliente = new cliente()
                            {
                                idCliente = (int)resultado["idCliente"],
                                nombre = (string)resultado["nombre"],
                                apePater = (string)resultado["apePater"],
                                apeMater = (string)resultado["apeMater"],
                                dni = (int)resultado["dni"],
                                correo = (string)resultado["correo"],
                                estado = (string)resultado["estado"]
                            };
                            ListaClientes.Add(cliente);
                        }
                    }
                }
            }//sqlconecction
            return ListaClientes;
        }//buscarCliente
        
        //public List<Cliente> CrearCliente(Cliente c)
        public void CrearCliente(cliente c)
        {
            //List<Cliente> nuevoCliente = null;
            using (SqlConnection cn = new SqlConnection(ConexionDAO.getConexion()))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("RegistrarCliente", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@idCliente", c.idCliente));
                    cmd.Parameters.Add(new SqlParameter("@nombre", c.nombre));
                    cmd.Parameters.Add(new SqlParameter("@apePater",c.apePater));
                    cmd.Parameters.Add(new SqlParameter("@apeMater", c.apeMater));
                    cmd.Parameters.Add(new SqlParameter("@dni", c.dni));
                    cmd.Parameters.Add(new SqlParameter("@correo", c.correo));
                    cmd.ExecuteNonQuery();
                }
            }
            //nuevoCliente = BuscarCliente(Convert.ToString(c.idCliente));
            //return nuevoCliente;
        }
    }
}

//prueba