using ChurchCommunityBuilder.Api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Processes.Entity {
    [Serializable]
    [XmlRoot("ccb_api")]
    public class ProcessIndividualCollection {
        [XmlArrayItem("individual", typeof(ProcessIndividual))]
        [XmlArray("individuals")]
        public List<ProcessIndividual> ProcessIndividuals { get; set; }
    }
}
