using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Financial.Entity {
    public class AccountCollection : Response {
        public AccountCollection() {
            this.TransactionDetailTypes = new List<Account>();
        }

        [XmlArrayItem("transaction_detail_type", typeof(Account))]
        [XmlArray("transaction_detail_types")]
        public List<Account> TransactionDetailTypes { get; set; }
    }
}
