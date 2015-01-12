using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml;
using System.Xml.Serialization;
namespace ChurchCommunityBuilder.Api.Processes.Entity {
    public class ProcessQueueCollection {
        [Serializable]
        [XmlRoot("ccb_api")]
        public class ProcessCollection : Response {
            [XmlArrayItem("queues", typeof(Queue))]
            [XmlArray("queues")]
            public List<Queue> Queues { get; set; }
        }
    }
}
