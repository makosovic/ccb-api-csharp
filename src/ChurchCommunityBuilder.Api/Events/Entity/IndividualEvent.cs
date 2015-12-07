using System;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.People.Entity;

namespace ChurchCommunityBuilder.Api.Events.Entity {
    [Serializable]
    [XmlRoot("individual_event")]
    public class IndividualEvent {
        [XmlElement("individual")]
        public Individual Individual { get; set; }

        [XmlElement("event")]
        public Event Event { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }
    }
}
