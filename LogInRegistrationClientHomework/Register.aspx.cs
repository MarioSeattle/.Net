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
        registerVenue();
    }

    protected void registerVenue()
    {
        homework_5_31.ServiceLoginRegistrationhomeworkClient Isc =
        new homework_5_31.ServiceLoginRegistrationhomeworkClient();

        homework_5_31.Venue r =
        new homework_5_31.Venue();
        r.VenueName = VenueNameTextBox.Text;
        r.VenueAddress = VenueAddressTextBox.Text;
        r.VenueCity = VenueCityTextBox.Text;
        r.VenueState = VenueStateTextBox.Text;
        r.VenueZipCode = ZipCodeTextBox.Text;
        r.VenuePhone = VenuePhoneTextBox.Text;
        r.VenueEmail = VenueEmailTextBox.Text;
        r.VenueWebPage = VenueWebPageTextBox.Text;
        r.VenueAgeRestriction = int.Parse(AgeRestrictionTextBox.Text);
       

        bool result = Isc.RegisterVenue(r, EmailTextBox.Text, PasswordTextBox.Text);

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