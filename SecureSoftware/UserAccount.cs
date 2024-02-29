using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureSoftware
{
    public class UserAccount
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string CreatedAt { get; set; }
        public string LastEdited { get; set; }
        public string SiteName { get; set; }
        public string Notes { get; set; }

        public UserAccount(string userid, string username, string password, string email, string createdat, string lastedited = "" ,string sitename = "",string notes = "") { 
            UserID = userid;
            UserName = username;
            Password = password;
            Email = email;
            CreatedAt = createdat;
            LastEdited = lastedited;
            SiteName = sitename;
            Notes = notes;
        }

    } 
}
