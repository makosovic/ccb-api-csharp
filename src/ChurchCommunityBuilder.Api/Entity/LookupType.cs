using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Entity {
    public class LookupType {
        [XmlElement("id")]
        public int? ID { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("order")]
        public int Order { get; set; }
    }
}
