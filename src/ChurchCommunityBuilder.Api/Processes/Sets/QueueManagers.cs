using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Processes.Entity;
using ChurchCommunityBuilder.Api.Processes.QueryObject;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.Processes.Sets {
    public class QueueManagers : BaseApiSet<QueueManagerCollection> {
        public QueueManagers(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public IChurchCommunityBuilderResponse<QueueManagerCollection> List(int? processID, int? queueID ) {
            var qo = new QueueManagerQO { ProcessID = processID, QueueID = queueID };
            return this.List(qo);
        }

        public IChurchCommunityBuilderResponse<QueueManagerCollection> List(QueueManagerQO qo) {
            return this.Execute("queue_managers", qo);
        }
    }
}
