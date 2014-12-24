using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.People.Entity {
    public class FamilyMember {
        [XmlElement("individual")]
        public Lookup Individual { get; set; }
    }
}
