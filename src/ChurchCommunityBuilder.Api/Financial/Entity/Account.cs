using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.Financial.Entity {
    [Serializable]
    [XmlRoot("transaction_detail_type")]
    public class Account {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("cash_bank_account")]
        public string CashBankAccount { get; set; }

        [XmlElement("tax_deductible")]
        public bool TaxDeductible { get; set; }

        [XmlElement("online_giving_enabled")]
        public bool OnlineGivingEnabled { get; set; }

        [XmlElement("pledge_goal")]
        public decimal? PledgeGoal { get; set; }

        [XmlElement("parent")]
        public Lookup Parent { get; set; }

        [XmlArrayItem("campus", typeof(Lookup))]
        [XmlArray("campuses")]
        public List<Lookup> Campuses { get; set; }
    }
}
