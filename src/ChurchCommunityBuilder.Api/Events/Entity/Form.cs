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
    [XmlRoot("form")]
    public class Form {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("campus")]
        public Lookup Campus { get; set; }

        [XmlElement("confirmationText")]
        public string ConfirmationText { get; set; }

        [XmlElement("showConfirmationCode")]
        public string ShowConfirmationCode { get; set; }

        [XmlElement("start")]
        public DateTime? Start { get; set; }

        [XmlElement("end")]
        public DateTime? End { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }

        [XmlElement("public")]
        public bool Public { get; set; }

        [XmlElement("published")]
        public bool Published { get; set; }

        [XmlElement("disabled")]
        public bool Disabled { get; set; }

        [XmlElement("hasDiscountCodes")]
        public bool HasDiscountCodes { get; set; }

        [XmlElement("creator")]
        public Lookup Creator { get; set; }

        [XmlElement("modifier")]
        public Lookup Modifier { get; set; }

        [XmlElement("created")]
        public DateTime Created { get; set; }

        [XmlElement("modified")]
        public DateTime Modified { get; set; }
    }
}
