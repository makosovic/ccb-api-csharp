using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Util;
using System.Globalization;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.People.Entity;

namespace ChurchCommunityBuilder.Api.Financial.Entity {
    [Serializable]
    public class OnlineGift {
        public OnlineGift() {
            this.Individual = new GiftIndividual();
            this.Gifts = new List<Gift>();
        }
        [XmlAttribute("merchant-transaction-id")]
        public string MerchantTransactionID { get; set; }
        [XmlElement("confirmation_code")]
        public string ConfirmationCode { get; set; }
        [XmlElement("amount")]
        public double? Amount { get; set; }
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }
        [XmlElement("merchant_individual_id")]
        public int? MerchantIndividualID { get; set; }
        [XmlElement("merchant_authorization_code")]
        public string MerchantAuthorizationCode { get; set; }
        [XmlElement("merchant_notes")]
        public string MerchantNotes { get; set; }
        [XmlElement("merchant_status")]
        public string MerchantStatus { get; set; }
        [XmlElement("merchant_process_date")]
        public DateTime? MerchantProcessDate { get; set; }
        [XmlElement("payment_method")]
        public string PaymentMethod { get; set; }
        [XmlElement("payment_method_type")]
        public string PaymentMethodType { get; set; }
        [XmlElement("campus_id")]
        public int? CampusID { get; set; }
        [XmlElement("individual")]
        public GiftIndividual Individual { get; set; }

        [XmlArrayItem("gift", typeof(Gift))]
        [XmlArray("gifts")]
        public List<Gift> Gifts { get; set; }

        public bool ShouldSerializeAmount() {
            return this.Amount.HasValue;
        }

        public bool ShouldSerializeMerchantIndividualID() {
            return this.MerchantIndividualID.HasValue;
        }

        public bool ShouldSerializeConfirmationCode() {
            return !string.IsNullOrEmpty(this.ConfirmationCode);
        }
    }

    public class Gift {
        [XmlElement("coa_id")]
        public int CoaID { get; set; }
        [XmlElement("amount")]
        public double Amount { get; set; }
    }

    [XmlRoot("individual")]
    public class GiftIndividual {
        public GiftIndividual() {
            this.Address = new GiftAddress();
            this.Phones = new List<Phone>();
        }

        [XmlAttribute("id")]
        public int ID { get; set; } = 0;

        [XmlElement("first_name")]
        public string FirstName { get; set; }

        [XmlElement("last_name")]
        public string LastName { get; set; }

        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("address")]
        public GiftAddress Address { get; set; }

        [XmlArrayItem("phone", typeof(Phone))]
        [XmlArray("phones")]
        public List<Phone> Phones { get; set; }
    }

    [XmlRoot("address")]
    public class GiftAddress {
        public GiftAddress() {
            this.Country = new Country();
        }

        [XmlElement("street_address")]
        public string StreetAddress { get; set; }

        [XmlElement("city")]
        public string City { get; set; }


        [XmlElement("state")]
        public string State { get; set; }


        [XmlElement("zip")]
        public string Zip { get; set; }

        [XmlElement("country")]
        public Country Country { get; set; }
    }
}