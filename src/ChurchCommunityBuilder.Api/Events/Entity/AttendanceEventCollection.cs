using System.Collections.Generic;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.Events.Entity
{
    public class AttendanceEventCollection : Response
    {
        public AttendanceEventCollection()
        {
            this.Events = new List<AttendanceEvent>();
        }

        [XmlArrayItem("event", typeof(AttendanceEvent))]
        [XmlArray("events")]
        public List<AttendanceEvent> Events { get; set; }
    }
}
