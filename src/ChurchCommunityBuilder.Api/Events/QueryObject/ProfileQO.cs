using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Attributes;

namespace ChurchCommunityBuilder.Api.Events.QueryObject {
    public class ProfileQO : ChurchCommunityBuilder.Api.QueryObject {
        [QO("modified_since")]
        public DateTime? ModifiedSince { get; set; }

        [QO("include_guest_list")]
        public bool? IncludeGuestList { get; set; }
    }
}
