using System;
using ChurchCommunityBuilder.Api.People.QueryObject;
using NUnit.Framework;
using Shouldly;

namespace ChurchCommunityBuilder.Api.Tests.Integration.Financial.Batches {
    [TestFixture]
    public class BatchesListTest : BaseTest {
        [Test]
        public void integration_batch_get_batch_list() {
            var batches = base.ApiClient.Financials.Batches.List(DateTime.UtcNow.AddMonths(-12));
            batches.Data.Batches.Count.ShouldBeGreaterThan(0);
        }
    }
}
