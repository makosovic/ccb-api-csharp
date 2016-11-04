using System;
using ChurchCommunityBuilder.Api.Attributes;

namespace ChurchCommunityBuilder.Api.Events.QueryObject
{
    public class AttendanceQO : ChurchCommunityBuilder.Api.QueryObject
    {
        [QO("start_date")]
        public DateTime StartDate { get; set; }

        [QO("end_date")]
        public DateTime? EndDate { get; set; }
    }
   
}
