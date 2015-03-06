using ChurchCommunityBuilder.Api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Processes.Entity {
    [Serializable]
    public class ProcessIndividualCollection : Response {
        public ProcessIndividualCollection() {
            this.Individuals = new List<ProcessIndividual>();
        }
        [XmlArrayItem("individual", typeof(ProcessIndividual))]
        [XmlArray("individuals")]
        public List<ProcessIndividual> Individuals { get; set; }
    }
}
