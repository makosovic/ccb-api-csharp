using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using ChurchCommunityBuilder.Api;
using ChurchCommunityBuilder.Api.Processes.Entity;
using ChurchCommunityBuilder.Api.Processes.QueryObject;

namespace ChurchCommunityBuilder.Api.Tests.Integration.Process {
    [TestFixture]
    public class QueueManagerSearchTests : BaseTest {
        [Test]
        public void integration_queue_managers_search_qo() {
            var results = _apiClient.Processes.QueueManagers.List(new QueueManagerQO { QueueID = 1861 });
            results.Managers.Count.ShouldBeGreaterThan(0);
        }
    }
}
