using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Financial.Entity.Import {
    [XmlRoot("transaction_detail")]
    public class TransactionDetail {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("coa")]
        public Lookup COA { get; set; }

        [XmlElement("amount")]
        public decimal Amount { get; set; }

        [XmlElement("tax_deductible")]
        public bool TaxDeductible { get; set; }

        [XmlElement("note")]
        public string Note { get; set; }

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
