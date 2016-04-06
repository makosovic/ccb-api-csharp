using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity {
    public class MobileCarrierCollection : Response {
        public MobileCarrierCollection() {
            this.MobileCarriers = new List<MobileCarrier>();
        }

        [XmlArrayItem("mobile_carrier", typeof(MobileCarrier))]
        [XmlArray("mobile_carriers")]
        public List<MobileCarrier> MobileCarriers { get; set; }

    }
}
