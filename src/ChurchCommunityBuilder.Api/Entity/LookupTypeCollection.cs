using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace ChurchCommunityBuilder.Api.Entity {
    public class LookupTypeCollection : Response {
        public LookupTypeCollection() {
            this.Items = new List<LookupType>();
        }

        [XmlArrayItem("items", typeof(LookupType))]
        [XmlArray("item")]
        public new List<LookupType> Items { get; set; }
    }
}
