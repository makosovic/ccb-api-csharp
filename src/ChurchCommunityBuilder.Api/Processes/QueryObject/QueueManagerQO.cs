using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Attributes;

namespace ChurchCommunityBuilder.Api.Processes.QueryObject {
    public class QueueManagerQO : ChurchCommunityBuilder.Api.QueryObject {
        [QO("process_id")]
        public int? ProcessID { get; set; }

        [QO("manager_id")]
        public int? ManagerID { get; set; }

        [QO("queue_id")]
        public int? QueueID { get; set; }
    }
}
