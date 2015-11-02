using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Events.Entity;
using ChurchCommunityBuilder.Api.Entity;
using ChurchCommunityBuilder.Api.People.Entity;

namespace ChurchCommunityBuilder.Api.Groups.Entity {
    [Serializable]
    [XmlRoot("group")]
    public class Group {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("image")]
        public string Image { get; set; }

        [XmlElement("campus")]
        public Lookup Campus { get; set; }

        [XmlElement("main_leader")]
        public Participant MainLeader { get; set; }

        [XmlArrayItem("leaders", typeof(Participant))]
        [XmlArray("leader")]
        public List<Participant> Leaders { get; set; }

        [XmlArrayItem("participants", typeof(Participant))]
        [XmlArray("participant")]
        public List<Participant> Participants { get; set; }

        [XmlElement("group_type")]
        public Lookup GroupType { get; set; }

        [XmlElement("department")]
        public Lookup Department { get; set; }

        [XmlElement("area")]
        public Lookup Area { get; set; }

        [XmlElement("calendar_feed")]
        public string CalendarFeed { get; set; }

        [XmlArrayItem("registration_forms", typeof(RegistrationForm))]
        [XmlArray("form")]
        public List<RegistrationForm> RegistrationForms { get; set; }

        [XmlElement("current_members")]
        public int CurrentMembers { get; set; }

        [XmlElement("group_capacity")]
        public string GroupCapacity { get; set; }

        [XmlArrayItem("addresses", typeof(Address))]
        [XmlArray("address")]
        public List<Address> Addresses { get; set; }

        [XmlElement("meeting_day")]
        public Lookup MeetingDay { get; set; }

        [XmlElement("meeting_time")]
        public Lookup MeetingTime { get; set; }

        [XmlElement("childcare_provided")]
        public bool ChildcareProvided { get; set; }

        [XmlElement("interaction_type")]
        public string InteractionType { get; set; }

        [XmlElement("membership_type")]
        public string MembershipType { get; set; }

        [XmlElement("notification")]
        public bool Notification { get; set; }

        //TODO :: Figure out User defined fields

        [XmlElement("listed")]
        public bool Listed { get; set; }

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
