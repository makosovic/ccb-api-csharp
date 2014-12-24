using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Entity {
    [XmlRoot("argument")]
    public class Argument {
        [XmlAttribute("value")]
        public string Value { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
