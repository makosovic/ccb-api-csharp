using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.People.Entity {
    [XmlRoot("address")]
    public class Address {
        public Address() {
            this.Country = new Lookup();
        }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlElement("street_address")]
        public string StreetAddress { get; set; }

        [XmlElement("city")]
        public string City { get; set; }


        [XmlElement("state")]
        public string State { get; set; }


        [XmlElement("zip")]
        public string Zip { get; set; }


        [XmlElement("country")]
        public Lookup Country { get; set; }

        [XmlElement("line_1")]
        public string Line1 { get; set; }

        [XmlElement("line_2")]
        public string Line2 { get; set; }
    }
}
