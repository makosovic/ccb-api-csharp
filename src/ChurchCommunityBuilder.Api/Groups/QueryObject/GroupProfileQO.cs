using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Attributes;

namespace ChurchCommunityBuilder.Api.Groups.QueryObject {
    public class GroupProfileQO : ChurchCommunityBuilder.Api.QueryObject {
        [QO("modified_since")]
        public DateTime? ModifiedSince { get; set; }

        [QO("include_participants")]
        public bool? IncludeParticipants { get; set; }
    }
}