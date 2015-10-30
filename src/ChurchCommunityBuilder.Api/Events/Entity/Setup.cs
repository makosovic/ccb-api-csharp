using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;
using ChurchCommunityBuilder.Api.People.Entity;

namespace ChurchCommunityBuilder.Api.Events.Entity {
    [Serializable]
    [XmlRoot("setup")]
    public class Setup {
        [XmlElement("start")]
        public DateTime? Start { get; set; }

        [XmlElement("end")]
        public DateTime? End { get; set; }

        [XmlElement("notes")]
        public string Notes { get; set; }
    }
}
