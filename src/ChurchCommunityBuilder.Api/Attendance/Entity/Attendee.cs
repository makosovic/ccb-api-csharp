using System;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Attendance.Entity
{
    [Serializable]
    public class Attendee
    {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("first_name")]
        public string FirstName { get; set; }

        [XmlElement("last_name")]
        public string LastName { get; set; }
    }
}
