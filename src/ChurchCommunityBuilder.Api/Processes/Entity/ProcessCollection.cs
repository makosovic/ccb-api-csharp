using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml;
using System.Xml.Serialization;


namespace ChurchCommunityBuilder.Api.Processes.Entity {
    [Serializable]
    [XmlRoot("ccb_api")]
    public class ProcessCollection : Response {
        [XmlArrayItem("process", typeof(Process))]
        [XmlArray("processes")]
        public List<Process> Processes { get; set; }
    }
}
