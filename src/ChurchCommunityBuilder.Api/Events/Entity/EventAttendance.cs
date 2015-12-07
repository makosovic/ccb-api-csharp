using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Events.Entity {
    [Serializable]
    [XmlRoot("event")]
    public class EventAttendance {
        public EventAttendance() {
            this.Attendees = new List<Attendee>();
        }

        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlAttribute("occurrence")]
        public DateTime Occurrence { get; set; }

        [XmlElement("did_not_meet")]
        public bool DidNotMeet { get; set; }

        [XmlElement("head_count")]
        public int HeadCount { get; set; }

        [XmlArrayItem("attendee", typeof(Attendee))]
        [XmlArray("attendees")]
        public List<Attendee> Attendees { get; set; }

        [XmlElement("topic")]
        public string Topic { get; set; }

        [XmlElement("notes")]
        public string Notes { get; set; }

        [XmlElement("prayer_requests")]
        public string PrayerRequests { get; set; }

        [XmlElement("info")]
        public string Info { get; set; }

        [XmlElement("email_notification")]
        public string EmailNotification { get; set; }
    }
}
