using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Entity {
    public class Lookup {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}
