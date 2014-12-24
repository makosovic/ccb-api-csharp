using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using ChurchCommunityBuilder.Api;
using ChurchCommunityBuilder.Api.People.Entity;
using ChurchCommunityBuilder.Api.People.QueryObject;

namespace ChurchCommunityBuilder.Api.Tests.Integration {
    [TestFixture]
    public class IndividualSearchTests {
        private ApiClient _apiClient;
        [TestFixtureSetUp]
        public void Setup() {
            _apiClient = new ApiClient("multisite", "chadmeyer", "Psalms46:10");
        }

        [Test]
        public void integration_individual_search_search_by_name() {
            var qo = new IndividualQO();
            qo.FirstName = "chad";
            qo.LastName = "meyer";

            var results = _apiClient.Individuals.Search(qo);

            results.Request.Parameters.Count.ShouldBe(3);
        }
    }
}
