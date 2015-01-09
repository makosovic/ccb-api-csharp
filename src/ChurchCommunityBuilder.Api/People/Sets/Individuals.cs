using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api;
using ChurchCommunityBuilder.Api.People.Entity;
using ChurchCommunityBuilder.Api.People.QueryObject;

namespace ChurchCommunityBuilder.Api.People.Sets {
    public class Individuals : BaseApiSet<Individual> {
        public Individuals(string baseUrl, string username, string password) : base(baseUrl, username, password) {}

        public IndividualCollection Search(IndividualQO qo) {
            return this.Execute<IndividualCollection>(qo, "individual_search");
        }

        public Individual Get(int id) {
            var qo = new IndividualQO();
            qo.IndividualID = id;
            return this.Execute<Individual>(qo, "individual_profile_from_id");
        }
    }
}
