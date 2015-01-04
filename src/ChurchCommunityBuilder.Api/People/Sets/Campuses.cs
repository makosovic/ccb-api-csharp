using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.People.QueryObject;
using ChurchCommunityBuilder.Api.People.Entity;

namespace ChurchCommunityBuilder.Api.People.Sets {
    public class Campuses: BaseApiSet<Family> {
        public Campuses(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public CampusCollection List() {
            return this.Execute<CampusCollection>("campus_list");
        }
    }
}
