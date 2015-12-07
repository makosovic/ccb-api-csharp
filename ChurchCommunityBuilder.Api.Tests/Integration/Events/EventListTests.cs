using System;
using System.Collections.Generic;
using Shouldly;
using NUnit.Framework;

namespace ChurchCommunityBuilder.Api.Tests.Integration.Events {
    [TestFixture]
    public class EventListTests : BaseTest {
        [Test]
        public void integration_events_get_events() {
            var qo = new Api.Events.QueryObject.ProfileQO { PageNumber = 1, RecordsPerPage = 20, IncludeGuestList = true, ModifiedSince = new DateTime(2015, 10, 29) };
            var events = base.ApiClient.Events.Profiles.List(qo);
            events.Events.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_events_add_individual() {
            var individualEvents = ApiClient.Events.Events.AddIndividualToEvent(4414, 1878);
            individualEvents.Event.ID.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_events_add_attendance() {
            var individualIds = new List<int> {
                4414
            };

            var eventAttendance = ApiClient.Events.Events.CreateAttendance(individualIds, 1885, new DateTime(2015, 12, 2, 1, 00, 00));
            eventAttendance.HeadCount.ShouldBeGreaterThan(0);
        }
    }
}
