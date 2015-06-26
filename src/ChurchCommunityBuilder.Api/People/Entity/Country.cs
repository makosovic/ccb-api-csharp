using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.People.Entity {
    [XmlRoot("country")]
    public class Country {
        [XmlAttribute("code")]
        public string Code { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}
