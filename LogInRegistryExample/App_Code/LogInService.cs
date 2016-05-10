using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LogInService" in code, svc and config file together.
public class LogInService : ILogInService
{
    BookReviewDbEntities db = new BookReviewDbEntities();
   public bool RegisterReviewer(Reviewer r)
    {
        bool result = true;

        int pass = db.usp_NewReviewer(r.ReviewerUserName, r.ReviewerFirstName, r.ReviewerLastName, r.ReviewerEmail, r.ReviewPlainPassword);

        if(pass == -1)
        {
            result = false;
        }

        return result;
    }

    public int ReviewerLogin(string userName, string password)
    {
        int reviewerkey = 0;
        int result = db.usp_ReviewerLogin(userName, password);
        if (result != -1)
        {
            var key = (from r in db.Reviewers
                      where r.ReviewerUserName.Equals(userName)
                      select new { r.ReviewerKey }).FirstOrDefault();

            reviewerkey = key.ReviewerKey;
        }

        return reviewerkey;
           
    }
}
