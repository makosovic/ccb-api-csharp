using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity {
    public class HowTheyHeardCollection : Response {
        public HowTheyHeardCollection() {
            this.Items = new List<HowTheyHeard>();
        }

        [XmlArrayItem("items", typeof(HowTheyHeard))]
        [XmlArray("items")]
        public List<HowTheyHeard> Items { get; set; }
    }
}
