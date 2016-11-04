using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Attendance.Entity
{
    
    [Serializable]
    [XmlRoot("event")]
    public class AttendanceEvent
    {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("occurrence")]
        public string Occurrence { get; set; }

        [XmlElement("did_not_meet")]
        public bool DidNotMeet { get; set; }
        
        [XmlArrayItem("attendees", typeof(Attendee))]
        [XmlArray("attendee")]
        public List<Attendee> Attendees { get; set; }

        [XmlElement("head_count")]
        public bool HeadCount { get; set; }

        //todo: add <topic/> <notes/> <prayer_requests/>
    }
}
