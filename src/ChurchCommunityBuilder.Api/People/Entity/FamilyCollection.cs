using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity {
    public class FamilyCollection : Response {
        [XmlElement("families")]
        public List<Family> Families { get; set; }
    }
}
