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
    [XmlRoot("event")]
    public class Event {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("leader_notes")]
        public string LeaderNotes { get; set; }

        [XmlElement("start_datetime")]
        public DateTime? StartDateTime { get; set; }

        [XmlElement("end_datetime")]
        public DateTime? EndDateTime { get; set; }

        [XmlElement("timezone")]
        public string TimeZone { get; set; }

        [XmlElement("recurrence_description")]
        public string RecurrenceDescription { get; set; }

        [XmlArrayItem("exceptions", typeof(Exception))]
        [XmlArray("exception")]
        public List<Exception> Exceptions { get; set; }

        [XmlElement("approval_status")]
        public Lookup ApprovalStatus { get; set; }

        [XmlElement("group")]
        public Lookup Group { get; set; }

        [XmlElement("organizer")]
        public Lookup Organizer { get; set; }

        [XmlElement("phone")]
        public Phone Phone { get; set; }

        [XmlElement("location")]
        public Location Location { get; set; }

        [XmlElement("registration")]
        public Registration Registration { get; set; }

        [XmlArrayItem("guest_list", typeof(Guest))]
        [XmlArray("guest")]
        public List<Guest> GuestList { get; set; }

        //TODO :: undestand resoureces
        // Resources are not returned, maybe reach out to CCB

        [XmlElement("setup")]
        public Setup Setup { get; set; }

        [XmlElement("event_grouping")]
        public Lookup EventGrouping { get; set; }

        [XmlElement("creator")]
        public Lookup Creator { get; set; }

        [XmlElement("modifier")]
        public Lookup Modifier { get; set; }

        [XmlElement("created")]
        public DateTime Created { get; set; }

        [XmlElement("modified")]
        public DateTime Modified { get; set; }
    }
}
