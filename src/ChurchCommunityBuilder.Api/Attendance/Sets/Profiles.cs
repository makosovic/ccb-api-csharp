using System;
using System.Collections.Generic;
using ChurchCommunityBuilder.Api.Attendance.Entity;
using ChurchCommunityBuilder.Api.Attendance.QueryObject;

namespace ChurchCommunityBuilder.Api.Attendance.Sets
{
    public class Profiles : BaseApiSet<AttendanceEventCollection>
    {
        public Profiles(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public AttendanceEventCollection List(AttendanceQO qo)
        {
            return this.Execute("attendance_profiles", qo);
        }

        public AttendanceEvent Get(int id, DateTime occurrence)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            parameters.Add("occurrence", occurrence.ToString("yyyy-MM-dd"));
            return this.Execute<AttendanceEvent>("attendance_profile", parameters);
        }

    }
}
