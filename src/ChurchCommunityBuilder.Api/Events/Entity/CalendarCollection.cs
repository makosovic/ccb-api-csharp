using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Events.Entity {
    [Serializable]
    public class CalendarCollection : Response {
        [XmlArrayItem("items", typeof(Lookup))]
        [XmlArray("item")]
        public List<Lookup> Items { get; set; }
    }
}
