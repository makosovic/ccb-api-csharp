using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity {
    public class IndividualCollection : Response {
        public IndividualCollection() {
            this.Individuals = new List<Individual>();
        }

        [XmlArrayItem("individual", typeof(Individual))]
        [XmlArray("individuals")]
        public List<Individual> Individuals { get; set; }
    }
}
