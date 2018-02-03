using System;
using System.Collections.Generic;
using ChurchCommunityBuilder.Api.Events.Entity;
using ChurchCommunityBuilder.Api.Events.QueryObject;

namespace ChurchCommunityBuilder.Api.Events.Sets
{
    public class Attendance : BaseApiSet<AttendanceEventCollection>
    {
        public Attendance(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

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
