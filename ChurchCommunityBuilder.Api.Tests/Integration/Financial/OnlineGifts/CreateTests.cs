using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using ChurchCommunityBuilder.Api;
using ChurchCommunityBuilder.Api.Financial.Entity;
using ChurchCommunityBuilder.Api.People.QueryObject;
using ChurchCommunityBuilder.Api.Extensions;

namespace ChurchCommunityBuilder.Api.Tests.Integration.Financial.OnlineGifts {
    [TestFixture]
    public class CreateTests : BaseTest { 
        [Test]
        public void integration_financial_online_gift_xml_test() {
            var rnd = new Random();

            //var onlineGift = new OnlineGift();
            //onlineGift.AccountID = 44; // Missions
            //onlineGift.CampusID = 1; // Main Campus
            //onlineGift.IndividualID = 4103; // Barney Rubble
            //onlineGift.GiftAmount = rnd.Next(3, 176);
            //onlineGift.MerchantAuthorizationCode = "2346356";

            //var returnGift = base.ApiClient.Financials.OnlineGifts.Create(onlineGift);
            //returnGift.ShouldNotBe(null);
            var list = new OnlineGiftCollection();

            var onlineGift = new OnlineGift();
            onlineGift.MerchantName = "52projects";
            onlineGift.MerchantTransactionID = "234vn23rnf23h";
            onlineGift.MerchantProcessDate = DateTime.UtcNow;
            onlineGift.MerchantStatus = "Settled";
            onlineGift.MerchantNotes = "donated for Debbie Sutton";
            onlineGift.MerchantAuthorizationCode = "12351";
            onlineGift.PaymentMethodType = "Other";
            onlineGift.CampusID = 1;
            onlineGift.Individual.FirstName = "Joe";
            onlineGift.Individual.LastName = "Doe";
            onlineGift.Individual.Email = "joedoe@focusministry.com";
            onlineGift.Individual.Address.StreetAddress = "123 Test Rd";
            onlineGift.Individual.Address.City = "Testville";
            onlineGift.Individual.Address.State = "TX";
            onlineGift.Individual.Address.Country.Code = "US";
            onlineGift.Individual.Address.Country.Value = "United States";
            onlineGift.Individual.Phones.Add(new People.Entity.Phone { Type = "contact", Value = "5559584151" });
            onlineGift.Gifts.Add(new Gift { Amount = rnd.Next(3, 176), CoaID = 44 });

            list.Items.Add(onlineGift);

            base.ApiClient.Financials.OnlineGifts.Batch(list);
        }
    }
}
