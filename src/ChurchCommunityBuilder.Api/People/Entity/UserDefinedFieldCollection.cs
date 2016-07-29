using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity {
    public class UserDefinedFieldCollection : Response {
        public UserDefinedFieldCollection() {
            this.UserDefinedFields = new List<UserDefinedField>();
        }

        [XmlArrayItem("campus", typeof(UserDefinedField))]
        [XmlArray("campuses")]
        public List<UserDefinedField> UserDefinedFields { get; set; }
    }
}
