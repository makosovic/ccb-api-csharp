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
    public class FormTests : BaseTest {
        [Test]
        public void integration_forms_get_form() {
            var profile = base.ApiClient.Events.Profiles.Get(1627);

            var registration = profile.Registration.Forms[0];
            var form = base.ApiClient.Events
        }
    }
}
