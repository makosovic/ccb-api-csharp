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
        [XmlArrayItem("items", typeof(Calendar))]
        [XmlArray("item")]
        public List<Calendar> Items { get; set; }
    }
}
