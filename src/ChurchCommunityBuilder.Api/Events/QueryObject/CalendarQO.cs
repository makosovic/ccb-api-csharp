using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Attributes;

namespace ChurchCommunityBuilder.Api.Events.QueryObject {
    public class CalendarQO : ChurchCommunityBuilder.Api.QueryObject {
        [QO("date_start")]
        public DateTime DateStart { get; set; }

        [QO("date_end")]
        public DateTime? DateEnd { get; set; }
    }
}