using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceLoginRegistrationhomework" in code, svc and config file together.
public class ServiceLoginRegistrationhomework : IServiceLoginRegistrationhomework
{
    ShowTrackerEntities1 db = new ShowTrackerEntities1();
    public int RegisterLogIn(string userName, string password)
    {
        int VenueLogInkey = 0;
        int result = db.usp_venueLogin(userName, password);
        if (result != -1)
        {
            var key = (from r in db.VenueLogins
                       where r.VenueLoginUserName.Equals(userName)
                       select new { r.VenueKey }).FirstOrDefault();

            VenueLogInkey = (int)key.VenueKey;
        }

        return VenueLogInkey;
    }

    public bool RegisterVenue(Venue r, string username, string password)
    {
        bool result = true;

        int pass = db.usp_RegisterVenue(r.VenueName, r.VenueAddress, r.VenueCity, r.VenueState, r.VenueZipCode, r.VenuePhone, r.VenueEmail, r.VenueWebPage, r.VenueAgeRestriction, username, password);

        if (pass == -1)
        {
            result = false;
        }

        return result;
    }
}
