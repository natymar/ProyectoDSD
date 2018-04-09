using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {


           

            string mensaje;

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Debe de completar el formulario" + "');", true);
                return;
            }
            
            WCFServiceUsuario.UsuarioWS.UsuariosClient proxy = new WCFServiceUsuario.UsuarioWS.UsuariosClient();
            //    int usuarioxiste = proxy.VerificarUsuario((txtNombre.Text, txtPassword.Text));

            int usuarioxiste = 0;
            if (usuarioxiste > 0)
            {
                Response.Redirect("PAGINA.ASPX");
            }
            else
            {
                mensaje = "alert(\'Usuario Denegado\');";
                ScriptManager.RegisterStartupScript(this, typeof(Type), "alert", mensaje, true);
            }
        }
    }
}