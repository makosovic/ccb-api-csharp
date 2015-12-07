using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Events.Entity {
    [Serializable]
    [XmlRoot("attendee")]
    public class Attendee {
        [XmlAttribute("id")]
        public int ID { get; set; }
    }
}
