using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceLoginRegistrationhomework" in both code and config file together.
[ServiceContract]
public interface IServiceLoginRegistrationhomework
{
    [OperationContract]
    bool RegisterVenue(Venue r, string username, string password);

    [OperationContract]
    int RegisterLogIn(string userName, string password);


}
