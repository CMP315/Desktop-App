using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureSoftware.Classes
{
    public class UserAccount
    {
        public string _id { get; set; }
        public string user_id { get; set; }
        public string username { get; set; }
        public string created_at { get; set; }
        public string password { get; set; }
        public string last_edited_at { get; set; }
        public string site_name { get; set; }
        public string notes { get; set; }

        public UserAccount(
            string _id,
            string user_id,
            string username,
            string created_at = "",
            string password = "",
            string last_edited_at = "",
            string site_name = "",
            string notes = ""
        )
        {
            this._id = _id;
            this.user_id = user_id;
            this.username = username;
            this.created_at = created_at;
            this.password = password;
            this.last_edited_at = last_edited_at;
            this.site_name = site_name;
            this.notes = notes;
        }
    }
}
