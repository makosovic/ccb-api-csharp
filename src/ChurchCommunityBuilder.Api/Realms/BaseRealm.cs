using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchCommunityBuilder.Api.Realms {
    public class BaseRealm {
        internal const string API_URL = "https://{0}.ccbchurch.com/api.php";

        #region Properties
        public string UserName { get; set; }
        internal string Password { get; set; }
        internal string ChurchCode { get; set; }
        #endregion Properties

        public BaseRealm(string churchCode, string username, string password) {
            this.UserName = username;
            this.Password = password;
            this.ChurchCode = churchCode;
        }
    }
}
