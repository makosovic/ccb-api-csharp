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


namespace ChurchCommunityBuilder.Api.Tests.Integration.Events {
    [TestFixture]
    public class CalendarTests : BaseTest {
        [Test]
        public void integration_calendars_get_calendar() {
            var qo = new Api.Events.QueryObject.CalendarQO { DateStart = new DateTime(1015, 10, 20), DateEnd = new DateTime(1015, 10, 29) };
            var events = base.ApiClient.Events.Calendar.List(qo);
            events.Items.Count.ShouldBeGreaterThan(0);
        }
    }
}
