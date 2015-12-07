using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Events.Entity {
    [Serializable]   
    [XmlRoot("events")] 
    public class EventAttendanceCollection {
        public EventAttendanceCollection() {
            this.EventAttendances = new List<EventAttendance>();
        }
        [XmlElement("event")]
        public List<EventAttendance> EventAttendances { get; set; }
    }
}