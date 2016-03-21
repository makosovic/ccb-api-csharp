using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Events.Entity {
    public class FormCollection : Response {
        public FormCollection() {
            this.Forms = new List<Form>();
        }

        [XmlArrayItem("form", typeof(Event))]
        [XmlArray("forms")]
        public List<Form> Forms { get; set; }
    }
}
