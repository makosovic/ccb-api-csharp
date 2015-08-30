using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.People.QueryObject;
using ChurchCommunityBuilder.Api.People.Entity;

namespace ChurchCommunityBuilder.Api.People.Sets {
    public class HowTheyHeardSet : BaseApiSet<HowTheyHeardCollection> {
        public HowTheyHeardSet(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public HowTheyHeardCollection List() {
            var list = this.Execute("how_they_heard_list");
            return list;
        }
    }
}
