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
    [XmlRoot("online_igfts")]
    public class OnlineGiftCollection {
        public OnlineGiftCollection() {
            this.Items = new List<OnlineGift>();
        }

        [XmlArrayItem("online_gift", typeof(OnlineGift))]
        [XmlArray("online_gifts")]
        public List<OnlineGift> Items { get; set; }

    }
}
