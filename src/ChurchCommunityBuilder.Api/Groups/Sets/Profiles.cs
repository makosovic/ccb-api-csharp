using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Groups.QueryObject;
using ChurchCommunityBuilder.Api.Groups.Entity;

namespace ChurchCommunityBuilder.Api.Groups.Sets {
    public class Profiles : BaseApiSet<GroupCollection> {
        public Profiles(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public GroupCollection List(GroupProfileQO qo) {
            return this.Execute("group_profiles", qo);
        }

        public Group Get(int id) {
            var parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            return this.Execute<Group>("group_profile_from_id", parameters);
        }
    }
}
