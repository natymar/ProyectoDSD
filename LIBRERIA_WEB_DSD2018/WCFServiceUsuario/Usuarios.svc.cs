using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServiceUsuario.Dominio;
using WCFServiceUsuario.Errores;
using WCFServiceUsuario.Persistencia;

namespace WCFServiceUsuario
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Usuarios" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Usuarios.svc o Usuarios.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Usuarios : IUsuarios
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();


        public Usuario CrearUsuario(Usuario usuarioACrear)
        {

            if (usuarioDAO.obtener(usuarioACrear.codigoUsuario) != null)
            {
                throw new FaultException<UsuarioException>(
                    new UsuarioException()
                    {
                    Codigo = "101",
                    Description = "El usuario ya existe"
                }, 
                  new FaultReason("Error al intentar crear"));
        }
          return  usuarioDAO.crear(usuarioACrear);
        }

       
        public void EliminarUsuario(int codigo)
        {
            usuarioDAO.eliminar(codigo);
        }

        public List<Usuario> ListarUsuarios()
        {
            return usuarioDAO.listar();
        }

        public Usuario ModificarUsuario(Usuario usuarioAModificar)
        {
            return usuarioDAO.modificar(usuarioAModificar);
        }

        public Usuario ObtenerUsuario(int codigo)
        {
            return usuarioDAO.obtener(codigo);
        }
    }
}