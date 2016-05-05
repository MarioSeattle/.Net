using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Service_3_5_16.ShowTrackerServiceClient bsc = new Service_3_5_16.ShowTrackerServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillDropDownVenues();
            FillDropDownArtist();
            FillDropDownShows();

        }
    }

    protected void FillDropDownVenues()

    {
        string[] Venues = bsc.GetVenues();
        DropDownVenues.DataSource = Venues;
        DropDownVenues.DataBind();
      

    }

    protected void FillDropDownArtist()

    {
        string[] Artist = bsc.GetArtist();
        DropDownArtist.DataSource = Artist;
        DropDownArtist.DataBind();


    }

    protected void FillDropDownShows()

    {
        string[] shows = bsc.GetShows();
        DropDownShows.DataSource = shows;
        DropDownShows.DataBind();


    }


    protected void ButtonVenue_Click(object sender, EventArgs e)
    {
        string venue = DropDownVenues.SelectedItem.Text;
        Service_3_5_16.ShowInfo[] shows = bsc.GetShowsVenue(venue);
        GridViewVenue_Shows.DataSource = shows;
        GridViewVenue_Shows.DataBind();

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        string artist = DropDownVenues.SelectedItem.Text;
        Service_3_5_16.ShowInfo[] shows = bsc.GetShowsVenue(artist);
        GridViewArtist_Shows.DataSource = shows;
        GridViewArtist_Shows.DataBind();
    }
}