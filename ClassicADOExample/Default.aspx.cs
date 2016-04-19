using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;//Added for database

public partial class _Default : System.Web.UI.Page
{
    DataClass dc = new DataClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LoadDropDownList();
    }
    protected void LoadDropDownList()
    {
        DataTable tbl = dc.GetServices();
        DropDownList1.DataSource = tbl;
        DropDownList1.DataTextField = "AuthorName";
        DropDownList1.DataValueField = "AuthorKey";
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0,"Choose one");


    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        FilGrid();
    }

    protected void FilGrid()
    {

        if (!DropDownList1.SelectedValue.Equals("Choose a Review"))

        {
            int key = int.Parse(DropDownList1.SelectedValue.ToString());
            DataTable tbl = dc.GetGrants(key);
            GridView1.DataSource = tbl;
            GridView1.DataBind();

        }
    }
}