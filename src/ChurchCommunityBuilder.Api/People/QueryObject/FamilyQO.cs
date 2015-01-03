using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Attributes;

namespace ChurchCommunityBuilder.Api.People.QueryObject {
    public class FamilyQO : ChurchCommunityBuilder.Api.QueryObject {
        [QO("family_id")]
        public int? FamilyID { get; set; }

        [QO("modified_since", "yyyy-mm-dd")]
        public DateTime? ModifiedSince { get; set; }
    }
}
