using System.Collections.Generic;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Events.Entity {
    public class EventCollection : Response {
        public EventCollection() {
            this.Events = new List<Event>();
        }

        [XmlArrayItem("event", typeof(Event))]
        [XmlArray("events")]
        public List<Event> Events { get; set; }
    }
}
