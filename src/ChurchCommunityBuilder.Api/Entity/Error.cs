using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Entity {
    [Serializable]
    [XmlRoot("error")]
    public class Error {
        [XmlText]
        public string Value { get; set; }
        [XmlAttribute("number")]
        public int Number { get; set; }
    }
}
