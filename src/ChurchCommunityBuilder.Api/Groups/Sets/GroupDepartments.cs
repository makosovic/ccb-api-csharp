using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Groups.QueryObject;
using ChurchCommunityBuilder.Api.Groups.Entity;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.Groups.Sets {
    public class GroupDepartments : BaseApiSet<LookupTypeCollection>
    {
        public GroupDepartments(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public IChurchCommunityBuilderResponse<LookupTypeCollection> List()
        {
            return this.Execute("group_grouping_list");
        }
    }
}
