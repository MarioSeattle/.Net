using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LogInBottom_Click(object sender, EventArgs e)
    {
        LogIn();
    }

    protected void LogIn()
    {
        RegisterServiceReference.LogInServiceClient rs =
            new RegisterServiceReference.LogInServiceClient();
        int key = rs.ReviewerLogin(UserTextBox.Text, Passwordtextbox.Text);
        if(key != 0)
        {
            Errorlabel.Text = "Welcome";
            Session["Userkey"] = key;
        }
        else
        {
            Errorlabel.Text = "Invalid LogIn";
        }



    }
}