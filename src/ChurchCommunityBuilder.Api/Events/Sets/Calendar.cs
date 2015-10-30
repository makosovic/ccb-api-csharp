using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using ChurchCommunityBuilder.Api.Events.Entity;
using ChurchCommunityBuilder.Api.Events.QueryObject;

namespace ChurchCommunityBuilder.Api.Events.Sets {
    public class Calendar : BaseApiSet<CalendarCollection> {
        public Calendar(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public CalendarCollection List(CalendarQO qo) {
            return this.Execute("public_calendar_listing", qo);
        }
    }
}
