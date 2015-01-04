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
    public class CampusListTests {
        private ApiClient _apiClient;
        [TestFixtureSetUp]
        public void Setup() {
            _apiClient = new ApiClient("multisite", "chadmeyer", "Psalms46:10");
        }

        [Test]
        public void integration_family_get_campus_list() {
            var campuses = _apiClient.People.Campuses.List();
            campuses.Campuses.Count.ShouldBeGreaterThan(0);
        }

    }
}
