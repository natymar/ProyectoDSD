using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 
namespace WebAplicacionLibreria2018.Cliente
{
    public partial class CrudClientes : System.Web.UI.Page
    {
       
        proxyConsumidor.ClientServiceClient proxy = new proxyConsumidor.ClientServiceClient();
        void listarALLclientes()
        {
            gridClientes.DataSource = proxy.ListarAllClientes();
            gridClientes.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listarALLclientes();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
           
            string filtro = (txtFiltro.Text).ToString();
            gridClientes.DataSource = proxy.BuscarCliente(filtro);
            gridClientes.DataBind();

        }
    }
}