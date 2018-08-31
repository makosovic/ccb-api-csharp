using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.People.QueryObject;
using ChurchCommunityBuilder.Api.People.Entity;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.People.Sets {
    public class Families : BaseApiSet<FamilyCollection> {
        public Families(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public IChurchCommunityBuilderResponse<FamilyCollection> Get(int familyID) {
            var qo = new FamilyQO { FamilyID = familyID };
            return this.Execute("family_list", qo);
        }

        public IChurchCommunityBuilderResponse<FamilyCollection> List(DateTime modifiedSince) {
            var qo = new FamilyQO { ModifiedSince = modifiedSince };
            return this.Execute("family_list", qo);
        }
    }
}
