using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceLoginRegistrationhomework" in code, svc and config file together.
public class ServiceLoginRegistrationhomework : IServiceLoginRegistrationhomework
{
    ShowTrackerEntities2 db = new ShowTrackerEntities2();

    public bool addartist(Artist a)
    {
        Artist artist = new Artist();
        artist.ArtistName = a.ArtistName;
        artist.ArtistDateEntered = DateTime.Now;
        bool result = true;
        try
        {
            db.Artists.Add(artist);
            db.SaveChanges();
        }
        catch (Exception ex)
        {
            result = false;
        }
        return result;
    }

    public bool addshow(Show s, ShowDetail sd)
    {
        Show show = new Show();
        ShowDetail showdetail = new ShowDetail();

        show.ShowDate = s.ShowDate;
        show.ShowDateEntered = DateTime.Now;
        show.ShowDetails = s.ShowDetails;
        show.ShowKey = s.ShowKey;
        show.ShowName = s.ShowName;
        show.ShowTicketInfo = s.ShowTicketInfo;
        show.ShowTime = s.ShowTime;
        showdetail.Show = show;
        showdetail.ArtistKey = sd.ArtistKey;
        showdetail.ShowDetailAdditional = sd.ShowDetailAdditional;
        showdetail.ShowDetailArtistStartTime = sd.ShowDetailArtistStartTime;
        
        
        bool result = true;
        try
        {
            db.Shows.Add(show);
            db.ShowDetails.Add(showdetail);
            db.SaveChanges();
        }
        catch
        {
            result = false;
        }

        return result;
    }

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
