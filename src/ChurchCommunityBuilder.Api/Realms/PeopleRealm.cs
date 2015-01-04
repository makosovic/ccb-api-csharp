using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchCommunityBuilder.Api.Realms {
    public class PeopleRealm : BaseRealm {
        public PeopleRealm(string churchCode, string username, string password)
            : base(churchCode, username, password) {

        }

        private ChurchCommunityBuilder.Api.People.Sets.Individuals _individualSet;
        private ChurchCommunityBuilder.Api.People.Sets.Families _familySet;
        private ChurchCommunityBuilder.Api.People.Sets.MembershipTypes _membershipTypesSet;
        private ChurchCommunityBuilder.Api.People.Sets.Campuses _campusesSet;

        #region Sets
        public ChurchCommunityBuilder.Api.People.Sets.Individuals Individuals {
            get {
                if (_individualSet == null) {
                    _individualSet = new People.Sets.Individuals(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _individualSet;
            }
        }

        public ChurchCommunityBuilder.Api.People.Sets.Families Families {
            get {
                if (_familySet == null) {
                    _familySet = new People.Sets.Families(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _familySet;
            }
        }

        public ChurchCommunityBuilder.Api.People.Sets.MembershipTypes MembershipTypes {
            get {
                if (_membershipTypesSet == null) {
                    _membershipTypesSet = new People.Sets.MembershipTypes(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _membershipTypesSet;
            }
        }

        public ChurchCommunityBuilder.Api.People.Sets.Campuses Campuses {
            get {
                if (_campusesSet == null) {
                    _campusesSet = new People.Sets.Campuses(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _campusesSet;
            }
        }
        #endregion Sets
    }
}
