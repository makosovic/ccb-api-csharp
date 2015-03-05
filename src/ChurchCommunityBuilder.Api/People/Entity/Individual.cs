using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.People.Enum;
using System.Web;

namespace ChurchCommunityBuilder.Api.People.Entity {
    [XmlRoot("individual")]
    public class Individual {
        public Individual() {
            this.Campus = new Lookup();
            this.Family = new Lookup();
            this.FamilyMembers = new List<FamilyMember>();
            this.Addresses = new List<Address>();
            this.Phones = new List<Phone>();
            this.MembershipType = new Lookup();
        }
        [XmlAttribute("id")]
        public int? ID { get; set; }

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

        [XmlIgnore]
        public FamilyPosition? FamilyPosition {
            get {
                if (!string.IsNullOrEmpty(this.FamilyPositionString)) {
                    switch (this.FamilyPositionString.ToLower()) {
                        case "primary contact":
                            return Enum.FamilyPosition.PrimaryContact;
                        case "head of household":
                            return Enum.FamilyPosition.HeadOfHousehold;
                        case "spouse":
                            return Enum.FamilyPosition.Spouse;
                        case "child":
                            return Enum.FamilyPosition.Child;
                        case "other":
                            return Enum.FamilyPosition.Other;
                            
                    }
                }
                return null;
            }
            set {
                switch (value) {
                    case Enum.FamilyPosition.PrimaryContact:
                        this.FamilyPositionString = "Primary Contact";
                        break;
                    case Enum.FamilyPosition.HeadOfHousehold:
                        this.FamilyPositionString = "Head of Household";
                        break;
                    case Enum.FamilyPosition.Spouse:
                        this.FamilyPositionString = "Spouse";
                        break;
                    case Enum.FamilyPosition.Child:
                        this.FamilyPositionString = "Child";
                        break;
                    case Enum.FamilyPosition.Other:
                        this.FamilyPositionString = "Other";
                        break;

                }
            }
        }

        [XmlElement("family_position")]
        public string FamilyPositionString { get; set; }

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
        public DateTime? Birthday { get; set; }

        [XmlElement("anniversary")]
        public DateTime? Anniversary { get; set; }

        [XmlElement("deceased")]
        public DateTime? Deceased { get; set; }

        [XmlElement("membership_date")]
        public DateTime? MembershipDate { get; set; }

        [XmlElement("membership_end")]
        public DateTime? MembershipEnd { get; set; }

        [XmlElement("membership_type")]
        public Lookup MembershipType { get; set; }

        public string GetFormValues() {
            bool needsAnd = false;
            var sb = new System.Text.StringBuilder();

            if (!string.IsNullOrEmpty(this.FirstName)) {
                if (needsAnd) {
                    sb.Append("&");
                }
                else {
                    needsAnd = true;
                }
                sb.AppendFormat("first_name={0}", HttpUtility.UrlEncode(this.FirstName));
            }

            if (!string.IsNullOrEmpty(this.LastName)) {
                if (needsAnd) {
                    sb.Append("&");
                }
                else {
                    needsAnd = true;
                }
                sb.AppendFormat("last_name={0}", HttpUtility.UrlEncode(this.LastName));
            }

            if (needsAnd) {
                sb.Append("&");
            }
            else {
                needsAnd = true;
            }

            sb.AppendFormat("middle_name={0}", this.MiddleName);
            sb.AppendFormat("&legal_first_name={0}", this.LegalFirstName);
            sb.AppendFormat("&sync_id={0}", this.SyncID);
            sb.AppendFormat("&other_id={0}", this.OtherID);
            sb.AppendFormat("&salutation={0}", this.Salutation);
            sb.AppendFormat("&suffix={0}", this.Suffix);

            if (Campus != null && Campus.ID.HasValue) {
                sb.AppendFormat("&campus_id={0}", this.Campus.ID);
            }

            if (this.Family != null && this.Family.ID.HasValue) {
                sb.AppendFormat("&family_id={0}", this.Family.ID);
            }

            if (!string.IsNullOrEmpty(this.FamilyPositionString)) {
                if (this.FamilyPositionString.ToLower() == "head of household" || this.FamilyPositionString.ToLower() == "primary contact") {
                    sb.AppendFormat("&family_position={0}", "h");
                }
                else if (this.FamilyPositionString.ToLower() == "spouse") {
                    sb.AppendFormat("&family_position={0}", "s");
                }
                else if (this.FamilyPositionString.ToLower() == "other") {
                    sb.AppendFormat("&family_position={0}", "o");
                }
                else if (this.FamilyPositionString.ToLower() == "child") {
                    sb.AppendFormat("&family_position={0}", "c");
                }
            }

            sb.AppendFormat("&gender={0}", this.Gender);
            sb.AppendFormat("&birthday={0}", this.Birthday.HasValue ? this.Birthday.Value.ToString("yyyy-MM-dd") : "");
            sb.AppendFormat("&anniversary={0}", this.Anniversary.HasValue ? this.Anniversary.Value.ToString("yyyy-MM-dd") : "");
            sb.AppendFormat("&deceased={0}", this.Deceased.HasValue ? this.Deceased.Value.ToString("yyyy-MM-dd") : "");
            sb.AppendFormat("&membership_date={0}", this.MembershipDate.HasValue ? this.MembershipDate.Value.ToString("yyyy-MM-dd") : "");
            sb.AppendFormat("&membership_end={0}", this.MembershipEnd.HasValue ? this.MembershipEnd.Value.ToString("yyyy-MM-dd") : "");
            sb.AppendFormat("&membership_type_id={0}", this.MembershipType != null && this.MembershipType.ID.HasValue ? this.MembershipType.ID.Value.ToString() : "");
            sb.AppendFormat("&giving_number={0}", this.GivingNumber);

            if (!string.IsNullOrEmpty(Email) && Email.Contains('@') && Email.Contains('.')) {
                sb.AppendFormat("&email={0}", this.Email.ToLower().Trim());
            }
            else {
                sb.AppendFormat("&email={0}", "");
            }

            if (this.Addresses != null && this.Addresses.Count > 0) {
                foreach (var current in Addresses) {
                    var addressType = current.Type;

                    var addressLLine = current.Line1;

                    if (!current.Line2.StartsWith(current.City)) {
                        addressLLine += " " + current.Line2;
                    }

                    sb.AppendFormat("&{0}_street_address={1}", current.Type, HttpUtility.UrlEncode(addressLLine.Trim()));
                    sb.AppendFormat("&{0}_city={1}", current.Type, HttpUtility.UrlEncode(current.City.Trim()));
                    sb.AppendFormat("&{0}_state={1}", current.Type, current.State.ToUpper().Trim());
                    sb.AppendFormat("&{0}_zip={1}", current.Type, current.Zip.Trim());
                }
            }

            if (this.Phones != null && this.Phones.Count > 0) {
                foreach (var current in this.Phones) {
                    sb.AppendFormat("&{0}_phone={1}", current.Type, HttpUtility.UrlEncode(current.Value.Trim()));
                }
            }

            return sb.ToString();
        }
    }
}
