using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAplicacionLibreria2018.WSPedidos;

namespace WebAplicacionLibreria2018.Pedido
{
    public partial class SolicitudCotizacion : System.Web.UI.Page
    {
        WSPedidos.PedidosClient proxy = new WSPedidos.PedidosClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_enviar_Click(object sender, EventArgs e)
        {
            FileUpload1.SaveAs(Server.MapPath(".") + "/Img_Listas/" + FileUpload1.FileName);

            try
            {
                Pedido nuevopedido = new Pedido();
                nuevopedido.Codigo = int.Parse(txt_cod.Text);
                nuevopedido.Lista = (FileUpload1.FileBytes);
                proxy.CrearArchivo(nuevopedido);
                //Response.Redirect("CrudClientes.aspx");
            }
            catch (Exception)
            {

            }
        }
    }
}