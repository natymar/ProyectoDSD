using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class About : Page
{
    DataTable dt2 = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        dt2 = (DataTable)Session["tabla"];

        GridView1.DataSource = dt2;
        GridView1.DataBind();
    }
}