using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitBottom_Click(object sender, EventArgs e)
    {

    }

    protected void registerReviewer()
    {
        RegisterServiceReference.LogInServiceClient Isc =
            new RegisterServiceReference.LogInServiceClient();

        RegisterServiceReference.Reviewer r = 
        new RegisterServiceReference.Reviewer();
        r.ReviewerLastName = LastNameTextBox.Text;
        r.ReviewerFirstName = FirstNameTextBox.Text;
        r.ReviewerEmail = EmailTextBox.Text;
        r.ReviewerUserName = LastNameTextBox.Text;
        r.ReviewPlainPassword = PasswordTextBox.Text;

        bool result = Isc.RegisterReviewer(r);

        if (result)
        {
            Response.Redirect("Default.aspx");

        }
        else 
        {
            ErrorLabel.Text = "Registration failled";

        }
    }
}