using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    DataTable dt = new DataTable();
    private ServiceReference1.ServiceProductosClient proxy = new ServiceReference1.ServiceProductosClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        //Filling the gridview using a service
        GridView1.DataSource = proxy.listarProductos();
        GridView1.DataBind();

        dt.Columns.Add("idProducto");
        dt.Columns.Add("marca");
        dt.Columns.Add("nombre");
        dt.Columns.Add("estado");
        dt.Columns.Add("cantidad");
        dt.Columns.Add("precio");

        if (!IsPostBack)
        {
            ViewState["table"] = dt;
        }

        GridView2.DataSource = dt;
        GridView2.DataBind();
    }

    protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;

        dt = (DataTable)ViewState["table"];
        DataRow _dr = dt.NewRow();

        _dr["idProducto"] = row.Cells[3].Text;
        _dr["marca"] = row.Cells[4].Text;
        _dr["nombre"] = row.Cells[5].Text;
        _dr["estado"] = row.Cells[2].Text;
        _dr["cantidad"] = row.Cells[1].Text;
        _dr["precio"] = row.Cells[6].Text;

        dt.Rows.Add(_dr);
        ViewState["table"] = dt;

        Session["tabla"] = dt;

        //optional just to see in the same webform that my datatable variable is not null
        GridView2.DataSource = dt;
        GridView2.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/About.aspx", false);
    }
}