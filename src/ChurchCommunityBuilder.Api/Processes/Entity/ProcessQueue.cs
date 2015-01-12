using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.Processes.Entity {
    [Serializable]
    [XmlRoot("queue")]
    public class Queue {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("description")]
        public Lookup Description { get; set; }

        [XmlElement("process")]
        public Lookup Process { get; set; }

        [XmlElement("order")]
        public int Order{ get; set; }

        [XmlArrayItem("manager", typeof(Lookup))]
        [XmlArray("managers")]
        public List<Lookup> Managers { get; set; }

        [XmlElement("creator")]
        public Lookup Creator { get; set; }

        [XmlElement("modifier")]
        public Lookup Modifier { get; set; }

        [XmlIgnore]
        public DateTime? CreatedDate {
            get {
                DateTime value = DateTime.MinValue;

                if (DateTime.TryParse(this.CreatedString, out value)) {
                    return value;
                }

                return null;
            }
            set {
                if (value.HasValue) {
                    this.CreatedString = value.Value.ToString();
                }
            }
        }

        private string _createdString = string.Empty;
        [XmlElement("created")]
        internal string CreatedString {
            get { return _createdString; }
            set { _createdString = value; }
        }

        [XmlIgnore]
        public DateTime? ModifiedDate {
            get {
                DateTime value = DateTime.MinValue;

                if (DateTime.TryParse(this.ModifiedString, out value)) {
                    return value;
                }

                return null;
            }
            set {
                if (value.HasValue) {
                    this.ModifiedString = value.Value.ToString();
                }
            }
        }

        private string _modifiedString = string.Empty;
        [XmlElement("modified")]
        internal string ModifiedString {
            get { return _modifiedString; }
            set { _modifiedString = value; }
        }
    }
}
