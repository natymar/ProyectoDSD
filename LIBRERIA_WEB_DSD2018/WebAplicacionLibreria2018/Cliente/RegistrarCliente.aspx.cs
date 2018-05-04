using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WScliente.Dominio;
using WScliente.Errores;

namespace WebAplicacionLibreria2018.Cliente
{
    public partial class RegistrarCliente : System.Web.UI.Page
    {
        ServiceReferenceWScliente.ClientServiceClient proxy = new ServiceReferenceWScliente.ClientServiceClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //comentario de prueba commit a
            
        }
        
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            
                      
            try
            {
                cliente cli = new cliente();
                cli.idCliente = int.Parse(txtCodigo.Text);
                cli.nombre = txtNombre.Text;
                cli.apePater = txtPaterno.Text;
                cli.apeMater = txtMaterno.Text;
                cli.dni = int.Parse(txtDni.Text);
                cli.correo = txtCorreo.Text;
                proxy.CrearCliente(cli);
                Response.Redirect("CrudClientes.aspx");
            }
            catch (Exception)
            {
                
               
            }
            

        }

        void mensaje(string msg)
        {
            Page.Controls.Add(
                       new LiteralControl("<script language='javascript'>" +
                           "window.alert('" + msg + "')</script>"));
            //limpiamos el datalis 
        }
    }
}