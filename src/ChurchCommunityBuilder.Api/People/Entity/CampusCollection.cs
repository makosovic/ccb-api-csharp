using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity {
    public class CampusCollection : Response {
        public CampusCollection() {
            this.Campuses = new List<Campus>();
        }

        [XmlArrayItem("campus", typeof(Campus))]
        [XmlArray("campuses")]
        public List<Campus> Campuses { get; set; }
    }
}
