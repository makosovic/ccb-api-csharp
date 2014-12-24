using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api;
using ChurchCommunityBuilder.Api.People.Entity;

namespace ChurchCommunityBuilder.Api.People.Sets {
    public class Individuals : BaseApiSet<Individual> {
        public Individuals(string baseUrl, string username, string password) : base(baseUrl, username, password) {}

        public IndividualCollection Search(ChurchCommunityBuilder.Api.QueryObject qo) {
            return this.Execute<IndividualCollection>(qo, "individual_search");
        }
    }
}
