using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ChurchCommunityBuilder.Api {
    public class ApiClient {
        #region Declarations
        private string _username;
        private string _password;
        private string _churchCode;
        private const string API_URL = "https://{0}.ccbchurch.com/api.php";
        private ChurchCommunityBuilder.Api.People.Sets.Individuals _individualSet;
        private ChurchCommunityBuilder.Api.People.Sets.Families _familySet;
        #endregion Declarations

        public ApiClient(string churchCode, string username, string password) {
            _username = username;
            _password = password;
            _churchCode = churchCode;
        }

        #region Sets
        public ChurchCommunityBuilder.Api.People.Sets.Individuals Individuals {
            get {
                if (_individualSet == null) {
                    _individualSet = new People.Sets.Individuals(string.Format(API_URL, _churchCode), _username, _password);
                }

                return _individualSet;
            }
        }

        public ChurchCommunityBuilder.Api.People.Sets.Families Families {
            get {
                if (_familySet == null) {
                    _familySet = new People.Sets.Families(string.Format(API_URL, _churchCode), _username, _password);
                }

                return _familySet;
            }
        }
        #endregion Sets
    }

    public enum ContentType {
        XML = 1,
        JSON = 2
    }
}
