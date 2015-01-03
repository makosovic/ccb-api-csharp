using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity {
    [XmlRoot("address")]
    public class Address {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlElement("street_address")]
        public string StreetAddress { get; set; }

        [XmlElement("city")]
        public string City { get; set; }
    }
}
