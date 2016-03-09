using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchCommunityBuilder.Api.Realms {
    public class EventsRealm : BaseRealm {
        public EventsRealm(string churchCode, string username, string password)
            : base(churchCode, username, password) {

        }

        private ChurchCommunityBuilder.Api.Events.Sets.Profiles _profilesSets;
        private ChurchCommunityBuilder.Api.Events.Sets.Calendar _calendarSets;
        private ChurchCommunityBuilder.Api.Events.Sets.Forms _formsSets;

        #region Sets
        public ChurchCommunityBuilder.Api.Events.Sets.Profiles Profiles {
            get {
                if (_profilesSets == null) {
                    _profilesSets = new Events.Sets.Profiles(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _profilesSets;
            }
        }

        public ChurchCommunityBuilder.Api.Events.Sets.Calendar Calendar {
            get {
                if (_calendarSets == null) {
                    _calendarSets = new Events.Sets.Calendar(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _calendarSets;
            }
        }

        public ChurchCommunityBuilder.Api.Events.Sets.Forms Forms {
            get {
                if (_formsSets == null) {
                    _formsSets = new ChurchCommunityBuilder.Api.Events.Sets.Forms(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _formsSets;
            }
        }
        #endregion Sets
    }
}