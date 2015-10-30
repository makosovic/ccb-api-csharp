using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Events.Entity {
    [XmlRoot("exception")]
    public class Exception {
        [XmlElement("date")]
        public DateTime Date { get; set; }
    }
}
