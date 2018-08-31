using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using ChurchCommunityBuilder.Api.Financial.Entity;

namespace ChurchCommunityBuilder.Api.Financial.Sets {
    public class Accounts : BaseApiSet<AccountCollection> {
        public Accounts(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public IChurchCommunityBuilderResponse<AccountCollection> List() {
            return this.Execute("transaction_detail_type_list");
        }
    }
}
