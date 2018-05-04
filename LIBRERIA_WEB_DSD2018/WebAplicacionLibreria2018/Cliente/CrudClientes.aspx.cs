using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//esto esta mal corregirlo
using WScliente.Dominio;

namespace WebAplicacionLibreria2018.Cliente
{
    public partial class CrudClientes : System.Web.UI.Page
    {
       
        ServiceReferenceWScliente.ClientServiceClient proxy = new ServiceReferenceWScliente.ClientServiceClient();
         
        
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

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            
        }
        //Metodos propios
        void listarALLclientes()
        {
            
            gridClientes.DataSource = proxy.ListarAllClientes();
            gridClientes.DataBind();
        }

        protected void gridClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "eliminar":
                    break;
                default:
                    break;
            }
        }

       

        protected void gridClientes_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            int idCodigo;
            idCodigo = int.Parse(gridClientes.Rows[e.RowIndex].Cells[2].Text);
            proxy.EliminarCliente(idCodigo);
            listarALLclientes();
        }

        protected void gridClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
           

        }

        protected void gridClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            cliente clienteModificar = new cliente();
            clienteModificar.nombre = gridClientes.Rows[e.RowIndex].Cells[3].Text.ToString();
            clienteModificar.apePater = gridClientes.Rows[e.RowIndex].Cells[4].Text.ToString();
            clienteModificar.apeMater = gridClientes.Rows[e.RowIndex].Cells[5].Text.ToString();
            clienteModificar.dni = 12345678;
            clienteModificar.correo = gridClientes.Rows[e.RowIndex].Cells[7].Text.ToString() ;
            clienteModificar.estado = gridClientes.Rows[e.RowIndex].Cells[8].Text.ToString();
            clienteModificar.idCliente = 999;
            proxy.ModificarCliente(clienteModificar);
            gridClientes.EditIndex = -1;
            listarALLclientes();
        }

        protected void gridClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridClientes.EditIndex = -1;
            listarALLclientes();
        }
    }
}