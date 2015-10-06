using ChurchCommunityBuilder.Api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Processes.Entity {
    [Serializable]
    public class QueueManagerCollection : Response {
        public QueueManagerCollection() {
            this.Managers = new List<QueueManager>();
        }
        [XmlArrayItem("manager", typeof(QueueManager))]
        [XmlArray("managers")]
        public List<QueueManager> Managers { get; set; }
    }
}
