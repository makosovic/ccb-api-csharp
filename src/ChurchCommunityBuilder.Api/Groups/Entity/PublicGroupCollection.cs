using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Groups.Entity {
    public class PublicGroupCollection : Response {
        public PublicGroupCollection() {
            this.Items = new List<Group>();
        }

        [XmlArrayItem("item", typeof(PublicGroup))]
        [XmlArray("items")]
        public new List<PublicGroup> Items { get; set; }
    }
}
