using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.People.Entity {
    [Serializable]
    [XmlRoot("campus")]
    public class Campus {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("ative")]
        public bool IsActive { get; set; }

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

    }
}
