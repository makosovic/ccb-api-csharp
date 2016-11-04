using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Attributes;

namespace ChurchCommunityBuilder.Api.Attendance.QueryObject
{
    public class AttendanceQO : ChurchCommunityBuilder.Api.QueryObject
    {
        [QO("start_date")]
        public DateTime StartDate { get; set; }

        [QO("end_date")]
        public DateTime? EndDate { get; set; }
    }
   
}
