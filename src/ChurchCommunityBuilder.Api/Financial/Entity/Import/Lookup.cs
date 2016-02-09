using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Financial.Entity.Import {
    public class Lookup {
        private int _id;
        [XmlAttribute("id")]
        public int ID {
            get {
                return _id;
            }
            set {
                _id = value;
            }
        }

        [XmlText]
        public string Value { get; set; }
    }
}
