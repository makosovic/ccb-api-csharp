using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.People.QueryObject;
using ChurchCommunityBuilder.Api.People.Entity;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.People.Sets {
    public class MobileCarriers : BaseApiSet<MobileCarrierCollection> {
        public MobileCarriers(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public IChurchCommunityBuilderResponse<MobileCarrierCollection> List() {
            return this.Execute("mobile_carrier_list");
        }
    }
}
