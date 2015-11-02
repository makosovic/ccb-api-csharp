using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Groups.Entity {
    public class GroupCollection : Response {
        public GroupCollection() {
            this.Groups = new List<Group>();
        }

        [XmlArrayItem("group", typeof(Group))]
        [XmlArray("groups")]
        public List<Group> Groups { get; set; }
    }
}
