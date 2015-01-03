using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity {
    [XmlRoot("individual")]
    public class Individual {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("sync_id")]
        public string SyncID { get; set; }

        [XmlElement("other_id")]
        public string OtherID { get; set; }

        [XmlElement("giving_number")]
        public string GivingNumber { get; set; }

        [XmlElement("campus")]
        public Lookup Campus { get; set; }

        [XmlElement("family")]
        public Lookup Family { get; set; }

        [XmlElement("family_image")]
        public string FamilyImage { get; set; }

        [XmlElement("family_position")]
        public string FamilyPosition { get; set; }

        [XmlElement("family_member")]
        public List<FamilyMember> FamilyMembers { get; set; }

        [XmlElement("first_name")]
        public string FirstName { get; set; }

        [XmlElement("middle_name")]
        public string MiddleName { get; set; }

        [XmlElement("last_name")]
        public string LastName { get; set; }

        [XmlElement("legal_first_name")]
        public string LegalFirstName { get; set; }

        [XmlElement("full_name")]
        public string FullName { get; set; }

        [XmlElement("salutation")]
        public string Salutation { get; set; }

        [XmlElement("suffix")]
        public string Suffix { get; set; }

        [XmlElement("image")]
        public string Image { get; set; }

        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("addresses")]
        public List<Address> Addresses { get; set; }

        [XmlArrayItem("phone", typeof(Phone))]
        [XmlArray("phones")]
        public List<Phone> Phones { get; set; }

        [XmlElement("gender")]
        public string Gender { get; set; }

        [XmlElement("marital_status")]
        public string MaritalStatus { get; set; }

        [XmlElement("birthday")]
        public DateTime Birthday { get; set; }
    }
}
