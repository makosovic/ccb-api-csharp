using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.People.QueryObject;
using ChurchCommunityBuilder.Api.People.Entity;

namespace ChurchCommunityBuilder.Api.People.Sets {
    public class Abilities : BaseApiSet<Ability> {
        public Abilities(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public Ability List() {
            return this.Execute("ability_list");
        }
    }
}
