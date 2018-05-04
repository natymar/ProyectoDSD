using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServiceUsuario.Dominio;
using WCFServiceUsuario.Errores;

namespace WCFServiceUsuario
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUsuarios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuarios
    {
        [FaultContract(typeof(UsuarioException))]
        [OperationContract]
        Usuario CrearUsuario(Usuario usuarioACrear);
        

        [OperationContract]
        Usuario ObtenerUsuario(int codigo);
        

        [OperationContract]
        Usuario ModificarUsuario(Usuario usuarioAModificar);

        [OperationContract]
        void EliminarUsuario(int dni);


        [OperationContract]
        List<Usuario> ListarUsuarios();

        [OperationContract]
        int VerificarUsuario(string usuario, string clave);

    }
}