using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Financial.Entity.Import {
    [XmlRoot("transaction")]
    public class Transaction {
        public Transaction() {
            this.TransactionDetails = new List<TransactionDetail>();
        }

        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("campus")]
        public Lookup Campus { get; set; }

        [XmlElement("individual")]
        public Lookup Individual { get; set; }

        [XmlElement("date")]
        public DateTime Date { get; set; }

        [XmlElement("grouping")]
        public Lookup Grouping { get; set; }

        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

        [XmlElement("check_number")]
        public string CheckNumber { get; set; }

        [XmlArrayItem("transaction_detail", typeof(TransactionDetail))]
        [XmlArray("transaction_details")]
        public List<TransactionDetail> TransactionDetails { get; set; }

        [XmlElement("creator")]
        public Lookup Creator { get; set; }

        [XmlElement("modifier")]
        public Lookup Modifier { get; set; }

        [XmlElement("created")]
        public DateTime Created { get; set; }

        [XmlElement("modified")]
        public DateTime? Modified { get; set; }
    }
}
