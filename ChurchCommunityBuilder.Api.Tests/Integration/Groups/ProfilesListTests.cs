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
    public class ProfileListsTests : BaseTest {
        [Test]
        public void integration_groups_list_groups() {
            var qo = new GroupProfileQO { IncludeParticipants = true };
            var results = base.ApiClient.Groups.GroupProfiles.List(qo);
            results.Groups.Count.ShouldBeGreaterThan(0);
        }
    }
}
