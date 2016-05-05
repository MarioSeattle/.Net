using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ServiceReference1.ServiceClient bsc = new ServiceReference1.ServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            FillAuthorDropDown();
        
    }

    protected void FillAuthorDropDown()

    {

        string[] authors = bsc.GetPositions();
        AuthorDropDownList.DataSource = authors;
        AuthorDropDownList.DataBind();

    }



    protected void BusinessButton_Click(object sender, EventArgs e)
    {
        string position = AuthorDropDownList.SelectedItem.Text;
        ServiceReference1.EmployeeInfo[] emp = bsc.GetEmployeeByPosition(position);
        BusinessGridView.DataSource = emp;
        BusinessGridView.DataBind();

    }
}