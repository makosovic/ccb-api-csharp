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
    [XmlRoot("item")]
    public class PublicGroup {
        [XmlElement("id")]
        public int ID { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("group_type_name")]
        public string GroupTypeName { get; set; }

        [XmlElement("grouping_name")]
        public string GroupingName { get; set; }


        [XmlElement("area_name")]
        public Lookup AreaName { get; set; }

        [XmlElement("meet_day_name")]
        public string MeetDayName { get; set; }

        [XmlElement("meet_time_name")]
        public string MeetTimeName { get; set; }

        [XmlElement("status_id")]
        public int? StatusId { get; set; }

        [XmlElement("membership_type")]
        public string MembershipType { get; set; }

        [XmlElement("messaging_type")]
        public string MessagingType { get; set; }

        [XmlElement("owner_name")]
        public Lookup OwnerName { get; set; }

        [XmlElement("owner_email_primary")]
        public string OwnerEmailPrimary { get; set; }
    }
}
