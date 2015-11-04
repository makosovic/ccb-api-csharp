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
    [XmlRoot("item")]
    public class Calendar {
        [XmlElement("date")]
        public DateTime? Date { get; set; }

        [XmlElement("event_name")]
        public Lookup EventName { get; set; }

        [XmlElement("event_description")]
        public string EventDescription { get; set; }

        [XmlElement("start_time")]
        public string StartTime { get; set; }

        [XmlElement("end_time")]
        public string EndTime { get; set; }

        [XmlElement("event_duration")]
        public decimal? EventDuration { get; set; }

        [XmlElement("event_type")]
        public string EventType { get; set; }

        [XmlElement("location")]
        public string Location { get; set; }

        [XmlElement("group_name")]
        public Lookup GroupName { get; set; }

        [XmlElement("group_type")]
        public string GroupType { get; set; }

        [XmlElement("grouping_name")]
        public string GroupingName { get; set; }

        [XmlElement("leader_name")]
        public Lookup LeaderName { get; set; }

        [XmlElement("leader_phone")]
        public string LeaderPhone { get; set; }

        [XmlElement("leader_email")]
        public string LeaderEmail { get; set; }
    }
}
