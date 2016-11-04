using System.Collections.Generic;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.Events.Entity
{
    public class AttendeeCollection : Response
    {
        public AttendeeCollection()
        {
            this.Attendees = new List<Attendee>();
        }

        [XmlArrayItem("attendee", typeof(Attendee))]
        [XmlArray("attendees")]
        public List<Attendee> Attendees { get; set; }
    }
}
