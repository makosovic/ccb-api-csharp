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

namespace ChurchCommunityBuilder.Api.Tests.Integration.Family {
    [TestFixture]
    public class FamilyListTest {
        private ApiClient _apiClient;
        [TestFixtureSetUp]
        public void Setup() {
            _apiClient = new ApiClient("multisite", "chadmeyer", "Psalms46:10");
        }

        [Test]
        public void integration_family_get_family_get() {
            var qo = new IndividualQO();
            qo.FirstName = "chad";
            qo.LastName = "meyer";

            var results = _apiClient.Individuals.Search(qo);

            var family = _apiClient.Families.Get(results.Individuals[0].Family.ID);

            family.ShouldNotBe(null);
        }

        [Test]
        public void integration_family_get_family_list() {
            var families = _apiClient.Families.List(DateTime.UtcNow.AddMonths(-3));
            families.Families.Count.ShouldBeGreaterThan(0);
        }
    }
}
