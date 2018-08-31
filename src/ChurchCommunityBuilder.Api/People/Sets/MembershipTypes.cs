using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.People.Entity;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.People.Sets {
    public class MembershipTypes : BaseApiSet<LookupTypeCollection> {
        public MembershipTypes(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public IChurchCommunityBuilderResponse<LookupTypeCollection> List() {
            return this.Execute("membership_type_list");
        }
    }
}
