using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchCommunityBuilder.Api.Realms {
    public class GroupsRealm : BaseRealm {
        public GroupsRealm(string churchCode, string username, string password)
            : base(churchCode, username, password) {

        }

        private ChurchCommunityBuilder.Api.Groups.Sets.Profiles _groupProfilesSet;
        private ChurchCommunityBuilder.Api.Groups.Sets.PublicGroups _publicGroupsSet;

        #region Sets
        public ChurchCommunityBuilder.Api.Groups.Sets.Profiles GroupProfiles {
            get {
                if (_groupProfilesSet == null) {
                    _groupProfilesSet = new Groups.Sets.Profiles(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _groupProfilesSet;
            }
        }

        public ChurchCommunityBuilder.Api.Groups.Sets.PublicGroups PublicGroups {
            get {
                if (_publicGroupsSet == null) {
                    _publicGroupsSet = new Groups.Sets.PublicGroups(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _publicGroupsSet;
            }
        }

        #endregion Sets
    }
}
