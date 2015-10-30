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
    [XmlRoot("registration")]
    public class Registration {
        [XmlElement("limit")]
        public int Limit { get; set; }

        [XmlElement("event_type")]
        public Lookup EventType { get; set; }

        [XmlArrayItem("registration_form", typeof(RegistrationForm))]
        [XmlArray("forms")]
        public List<RegistrationForm> Forms { get; set; }
    }
}
