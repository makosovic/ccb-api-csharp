using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Groups.QueryObject;
using ChurchCommunityBuilder.Api.Groups.Entity;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.Groups.Sets {
    public class Profiles : BaseApiSet<GroupCollection> {
        public Profiles(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public IChurchCommunityBuilderResponse<GroupCollection> List(GroupProfileQO qo) {
            return this.Execute("group_profiles", qo);
        }

        public IChurchCommunityBuilderResponse<Group> Get(int id) {
            var parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            return this.Execute<Group>("group_profile_from_id", parameters);
        }

        public IChurchCommunityBuilderResponse<Group> AddPersonToGroup(string individualID, string groupID, string status = "add") {
            var paramters = new Dictionary<string, string>();
            paramters.Add("id", individualID);
            paramters.Add("group_id", groupID);
            paramters.Add("status", status);

            return this.Execute<Group>("add_individual_to_group", paramters);
        }

        public IChurchCommunityBuilderResponse<Group> RemovePersonFromGroup(string individualID, string groupID) {
            var paramters = new Dictionary<string, string>();
            paramters.Add("id", individualID);
            paramters.Add("group_id", groupID);

            return this.Execute<Group>("remove_individual_from_group", paramters);
        }
    }
}
