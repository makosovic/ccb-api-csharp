using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Attributes;

namespace ChurchCommunityBuilder.Api.Processes.QueryObject {
    public class ProcessQO : ChurchCommunityBuilder.Api.QueryObject {
        [QO("campus_id")]
        public int? CampusID { get; set; }

        [QO("modified_since")]
        public DateTime? ModifiedSince { get; set; }
    }
}
