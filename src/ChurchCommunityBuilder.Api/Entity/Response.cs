using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Entity {
    public class Response {
        public Response() {
            this.Errors = new List<Error>();
            this.Items = new List<Lookup>();
        }

        public Request Request { get; set; }
        [XmlElement("service")]
        public string Service { get; set; }
        [XmlElement("service_action")]
        public string ServiceAction { get; set; }

        [XmlArrayItem("errors", typeof(Error))]
        [XmlArray("error")]
        public List<Error> Errors { get; set; }

        [XmlArrayItem("items", typeof(Lookup))]
        [XmlArray("item")]
        public List<Lookup> Items { get; set; }
    }
}
