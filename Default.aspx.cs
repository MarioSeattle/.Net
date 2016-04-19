using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    /* This is the first hands on project we worked on at .Net 172 Sprinf 2016  */
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButtom_Click(object sender, EventArgs e)
    {
        GetTimeTillBirthday();
    }

    protected void GetTimeTillBirthday()
    {
        DateTime birthDay;
        if (Calendar1.SelectedDate == null)
        {
            birthDay = DateTime.Now;
        }
        else
        {
            birthDay = Calendar1.SelectedDate;

        }

        string name = NameTextBox.Text;

        TimeSpan daysUntilBirthday = birthDay.Subtract(DateTime.Now);
        ResultLabel.Text = "Days until Birthday" + Math.Abs(daysUntilBirthday.Days).ToString() + ".And this many hours" + Math.Abs(daysUntilBirthday.Hours).ToString();
    }
}