using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShowTrackerService" in code, svc and config file together.
public class ShowTrackerService : IShowTrackerService
{
    ShowTrackerEntities db = new ShowTrackerEntities();
   public List<string> GetVenues()
    {
    var VenueQuery = from r in db.Venues
                orderby r.VenueName
                select new { r.VenueName };

    List<string> bVenue = new List<string>();
        foreach (var r in VenueQuery)
        { 
bVenue.Add(r.VenueName.ToString());
        }

        return bVenue;
    }
    public List<string> GetArtist()
    {
        var ArtistQuery = from r in db.Artists
                         orderby r.ArtistName
                         select new { r.ArtistName };

        List<string> bArtist = new List<string>();
        foreach (var r in ArtistQuery)
        {
            bArtist.Add(r.ArtistName.ToString());
        }

        return bArtist;
    }
    public List<string> GetShows()
    {
        var ShowQuery = from r in db.Shows
                          orderby r.ShowName
                          select new { r.ShowName };

        List<string> bShow = new List<string>();
        foreach (var r in ShowQuery)
        {
            bShow.Add(r.ShowName.ToString());
        }

        return bShow;
    }

    public List<ShowInfo> GetShowsVenue(string venueName)
    {
        var ShowVenueQuery = from r in db.Shows
                        orderby r.ShowDate
                        where r.Venue.VenueName==venueName
                        select new { r.ShowName, r.ShowDate, r.ShowTime, r.Venue.VenueName };

        List<ShowInfo> bShow = new List<ShowInfo>();
        foreach (var r in ShowVenueQuery)
        {
            ShowInfo info= new ShowInfo();
            info.ShowName = r.ShowName;
            info.ShowDate = r.ShowDate.ToString();
            info.ShowTime = r.ShowTime.ToString();
            bShow.Add(info);
        }

        return bShow;
    }

    public List<ShowInfo> GetShowArtist(string artistName)
    {
        var ShowArtistQuery = from r in db.Shows
                            from sd in r.ShowDetails
                             orderby r.ShowName
                             where sd.Artist.ArtistName == artistName
                             select new { r.ShowName, r.ShowDate, r.ShowTime, r.Venue.VenueName };

        List<ShowInfo> bShow = new List<ShowInfo>();
        foreach (var r in ShowArtistQuery)
        {
            ShowInfo info = new ShowInfo();
            info.ShowName = r.ShowName;
            info.ShowDate = r.ShowDate.ToString();
            info.ShowTime = r.ShowTime.ToString();
            bShow.Add(info);
        }

        return bShow;
    }
}
