using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Processes.Entity;
using ChurchCommunityBuilder.Api.Processes.QueryObject;

namespace ChurchCommunityBuilder.Api.Processes.Sets {
    public class Processes : BaseApiSet<ProcessCollection> {
        public Processes(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public ProcessCollection List(int? campusID = null, DateTime? modifiedSince = null) {
            var qo = new ProcessQO { CampusID = campusID, ModifiedSince = modifiedSince };
            return this.List(qo);
        }

        public ProcessCollection List(ProcessQO qo) {
            return this.Execute("process_list", qo);
        }

        public Queue AddPersonToQueue(string individualID, string queueID) {
            var paramters = new Dictionary<string, string>();
            paramters.Add("individual_id", individualID);
            paramters.Add("queue_id", queueID);
            return this.Execute<Queue>("add_individual_to_queue", paramters);
        }
    }
}
