using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;
using ChurchCommunityBuilder.Api.People.Entity;

namespace ChurchCommunityBuilder.Api.Events.Entity {
    [Serializable]
    [XmlRoot("guest")]
    public class Guest {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("first_name")]
        public string FirstName { get; set; }

        [XmlElement("last_name")]
        public string LastName { get; set; }

        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }

        //TODO :: Reach out to CCB because according to the documentation
        // there is a type attribute on the list phones when it should 
        // probably be just on the item itself
        [XmlArrayItem("phones", typeof(Phone))]
        [XmlArray("phone")]
        public List<Phone> Phones { get; set; }
    }
}
