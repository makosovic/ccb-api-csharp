using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using ChurchCommunityBuilder.Api;
using ChurchCommunityBuilder.Api.Groups.Entity;
using ChurchCommunityBuilder.Api.Groups.QueryObject;

namespace ChurchCommunityBuilder.Api.Tests.Integration.Groups {
    [TestFixture]
    public class PublicGroupSearchTest : BaseTest {
        [Test]
        public void integration_groups_search_groups() {
            var groups = ApiClient.Groups.PublicGroups.Search(new GroupProfileQO());
            groups.Groups.Count.ShouldBeGreaterThan(0);
        }
    }
}
