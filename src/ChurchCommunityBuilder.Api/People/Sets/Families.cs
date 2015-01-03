using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.People.QueryObject;
using ChurchCommunityBuilder.Api.People.Entity;

namespace ChurchCommunityBuilder.Api.People.Sets {
    public class Families : BaseApiSet<Family> {
        public Families(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public Family Get(int familyID) {
            var qo = new FamilyQO { FamilyID = familyID };
            var families = this.Execute<FamilyCollection>(qo, "family_list");

            if (families != null && families.Families.Count > 0) {
                return families.Families[0];
            }

            return null;
        }

        public FamilyCollection List(DateTime modifiedSince) {
            var qo = new FamilyQO { ModifiedSince = modifiedSince };
            return this.Execute<FamilyCollection>(qo, "family_list");
        }
    }
}
