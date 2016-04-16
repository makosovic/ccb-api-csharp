using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Groups.QueryObject;
using ChurchCommunityBuilder.Api.Groups.Entity;

namespace ChurchCommunityBuilder.Api.Groups.Sets {
    public class PublicGroups : BaseApiSet<PublicGroupCollection> {
        public PublicGroups(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public PublicGroupCollection Search(GroupProfileQO qo) {
            return this.Execute("group_search", qo);
        }
    }
}
