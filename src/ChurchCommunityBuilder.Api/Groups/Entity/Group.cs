using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Events.Entity;
using ChurchCommunityBuilder.Api.Entity;
using ChurchCommunityBuilder.Api.People.Entity;
using ChurchCommunityBuilder.Api.Util;

namespace ChurchCommunityBuilder.Api.Groups.Entity
{
    [Serializable]
    [XmlRoot("group")]
    public class Group
    {
        public Group()
        {
            this.Campus = new Lookup();
            this.MainLeader = new Participant();
            this.Leaders = new List<Participant>();
            this.Participants = new List<Participant>();
            this.GroupType = new Lookup();
            this.Department = new Lookup();
            this.Area = new Lookup();
            this.RegistrationForms = new List<RegistrationForm>();
            this.Addresses = new List<Address>();
            this.MeetingDay = new Lookup();
            this.MeetingTime = new Lookup();
            this.Creator = new Lookup();
            this.Modifier = new Lookup();

        }
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("image")]
        public string Image { get; set; }

        [XmlElement("campus")]
        public Lookup Campus { get; set; }

        [XmlElement("main_leader")]
        public Participant MainLeader { get; set; }

        [XmlArrayItem("leaders", typeof(Participant))]
        [XmlArray("leader")]
        public List<Participant> Leaders { get; set; }

        [XmlElement("coach")]
        public Participant Coach { get; set; }

        [XmlElement("director")]
        public Participant Director { get; set; }

        [XmlArrayItem("participants", typeof(Participant))]
        [XmlArray("participant")]
        public List<Participant> Participants { get; set; }

        [XmlElement("group_type")]
        public Lookup GroupType { get; set; }

        [XmlElement("department")]
        public Lookup Department { get; set; }

        [XmlElement("area")]
        public Lookup Area { get; set; }

        [XmlElement("calendar_feed")]
        public string CalendarFeed { get; set; }

        [XmlArrayItem("registration_forms", typeof(RegistrationForm))]
        [XmlArray("form")]
        public List<RegistrationForm> RegistrationForms { get; set; }

        [XmlElement("current_members")]
        public int CurrentMembers { get; set; }

        [XmlElement("group_capacity")]
        public string GroupCapacity { get; set; }

        [XmlArrayItem("addresses", typeof(Address))]
        [XmlArray("address")]
        public List<Address> Addresses { get; set; }

        [XmlElement("meeting_day")]
        public Lookup MeetingDay { get; set; }

        [XmlElement("meeting_time")]
        public Lookup MeetingTime { get; set; }

        [XmlElement("childcare_provided")]
        public bool ChildcareProvided { get; set; }

        [XmlElement("interaction_type")]
        public string InteractionType { get; set; }

        [XmlElement("membership_type")]
        public string MembershipType { get; set; }

        [XmlElement("notification")]
        public bool Notification { get; set; }

        //TODO :: Figure out User defined fields

        [XmlElement("listed")]
        public bool Listed { get; set; }

        [XmlElement("public_search_listed")]
        public bool PublicSearchListed { get; set; }

        [XmlElement("inactive")]
        public bool Inactive { get; set; }

        [XmlElement("creator")]
        public Lookup Creator { get; set; }

        [XmlElement("modifier")]
        public Lookup Modifier { get; set; }

        [XmlIgnore]
        public DateTime? CreatedDate
        {
            get
            {
                DateTime createdDate = DateTime.MinValue;

                if (DateTime.TryParse(_createdDateString, out createdDate))
                {
                    return createdDate;
                }

                return null;
            }
            set
            {
                if (value.HasValue)
                {
                    _createdDateString = value.Value.ToString();
                }
                else
                {
                    _createdDateString = string.Empty;
                }
            }
        }

        private string _createdDateString = string.Empty;
        [XmlElement("created")]
        public string Created
        {
            get
            {
                if (!string.IsNullOrEmpty(_createdDateString))
                {
                    DateTime dt = DateTime.Now;

                    if (DateTime.TryParse(_createdDateString, out dt))
                    {
                        _createdDateString = dt.ToString("s");
                    }
                }

                return _createdDateString;
            }
            set
            {
                if (value != null)
                {
                    _createdDateString = value;
                }
            }
        }

        [XmlIgnore]
        public DateTime? ModifiedDate
        {
            get
            {
                DateTime lastUpdatedDate = DateTime.MinValue;

                if (DateTime.TryParse(_lastUpdatedDateString, out lastUpdatedDate))
                {
                    return lastUpdatedDate;
                }

                return null;
            }
            set
            {
                if (value.HasValue)
                {
                    _lastUpdatedDateString = value.Value.ToString();
                }
                else
                {
                    _lastUpdatedDateString = string.Empty;
                }
            }
        }

        private string _lastUpdatedDateString = string.Empty;
        [XmlElement("modified")]
        public string Modified
        {
            get
            {
                if (!string.IsNullOrEmpty(_lastUpdatedDateString))
                {
                    DateTime dt = DateTime.Now;

                    if (DateTime.TryParse(_lastUpdatedDateString, out dt))
                    {
                        _lastUpdatedDateString = dt.ToString("s");
                    }
                }

                return _lastUpdatedDateString;
            }
            set
            {
                if (value != null)
                {
                    _lastUpdatedDateString = value;
                }
            }
        }

        public Dictionary<string, string> GetAsParameters()
        {
            var parameters = new Dictionary<string, string> { };

            if (!string.IsNullOrEmpty(this.Name))
            {
                parameters.Add("name", this.Name.Length > 50 ? this.Name.Substring(0, 50) : this.Name);
            }

            parameters.Add("campus_id", this.Campus.CCBID.ToString());
            parameters.Add("main_leader_id", this.MainLeader.ID.ToString());
            parameters.Add("description", this.Description);
            parameters.Add("listed", this.Listed.ToString());
            parameters.Add("public_search_listed", this.PublicSearchListed.ToString());

            if (this.GroupType.ID.HasValue)
            {
                parameters.Add("group_type_id", this.GroupType.ID.ToString());
            }

            if (this.Department.ID.HasValue)
            {
                parameters.Add("department_id", this.Department.ID.ToString());
            }

            if (this.Area.ID.HasValue)
            {
                parameters.Add("area_id", this.Area.ID.ToString());
            }

            if (!string.IsNullOrEmpty(this.GroupCapacity))
            {
                parameters.Add("group_capacity", this.GroupCapacity);
            }

            if (this.Addresses != null && this.Addresses.Count > 0)
            {
                foreach (var current in Addresses)
                {
                    var addressType = current.Type;
                    var addressLine = current.Line1;

                    if (!string.IsNullOrEmpty(current.Line2) && !current.Line2.StartsWith(current.City))
                    {
                        addressLine += " " + current.Line2;
                    }

                    parameters.Add(string.Format("{0}_street_address", current.Type), addressLine);
                    parameters.Add(string.Format("{0}_city", current.Type), current.City);
                    if (!string.IsNullOrEmpty(current.State))
                    {
                        parameters.Add(string.Format("{0}_state", current.Type), current.State.ToUpper());
                    }
                    parameters.Add(string.Format("{0}_zip", current.Type), current.Zip);

                    if (current.Country != null)
                    {
                        parameters.Add(string.Format("{0}_country", current.Type), current.Country.Code.ToUpper());
                    }
                }
            }

            return parameters;
        }

        public string GetFormValues()
        {
            var formValues = new FormValuesBuilder();

            var parameters = GetAsParameters();

            foreach (var parameter in parameters)
            {
                formValues.Add(parameter.Key, parameter.Value);
            }

            return formValues.ToString();
        }
    }
}
