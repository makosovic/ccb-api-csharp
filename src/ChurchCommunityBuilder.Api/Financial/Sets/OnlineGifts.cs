using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Financial.Entity;
using ChurchCommunityBuilder.Api.Entity;
using ChurchCommunityBuilder.Api.Extensions;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace ChurchCommunityBuilder.Api.Financial.Sets {
    public class OnlineGifts : BaseApiSet<OnlineGift> {
        public OnlineGifts(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public List<OnlineGift> Batch(OnlineGiftCollection gifts) {
            XmlSerializer serializer = new XmlSerializer(gifts.GetType(), new XmlRootAttribute("ccb_api"));

            using (StringWriter sw = new StringWriter()) {
                //Create our own namespaces for the output
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

                //Add an empty namespace and empty value
                ns.Add("", "");
                serializer.Serialize(sw, gifts, ns);
                var ret = sw.ToString().Replace("utf-16", "utf-8").Trim();
                var result = this.CreateWithXml("import_online_gifts", ret);
            }
            return null;

        }
    }
}
