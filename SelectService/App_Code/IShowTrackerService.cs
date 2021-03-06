﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShowTrackerService" in both code and config file together.
[ServiceContract]
public interface IShowTrackerService
{
    [OperationContract]
    List<string> GetVenues();

    [OperationContract]
    List<string> GetArtist();

    [OperationContract]
    List<string> GetShows();

    [OperationContract]
    List<ShowInfo> GetShowsVenue(string venueName);

    [OperationContract]
    List<ShowInfo> GetShowArtist(string artistName);


} //End interface

[DataContract]
public class ShowInfo
{
    [DataMember]
    public string VenueName { set; get; }

    [DataMember]
    public string ShowName { set; get; }

    [DataMember]
    public string ShowDate { set; get; }

    [DataMember]
    public string ShowTime { set; get; }

    
}
