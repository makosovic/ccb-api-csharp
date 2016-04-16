using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Attributes;

namespace ChurchCommunityBuilder.Api.Groups.QueryObject {
    public class GroupProfileQO : ChurchCommunityBuilder.Api.QueryObject {
        [QO("modified_since")]
        public DateTime? ModifiedSince { get; set; }

        [QO("include_participants")]
        public bool? IncludeParticipants { get; set; }

        [QO("area_id")]
        public int? AreaID { get; set; }

        [QO("campus_id")]
        public int? CampusID { get; set; }

        [QO("childcare")]
        public bool? ChildCare { get; set; }

        [QO("meet_day_id")]
        public int? MeetDayID { get; set; }

        [QO("meet_time_id")]
        public int? MeetTimeID { get; set; }

        [QO("department_id")]
        public int? DepartmentID { get; set; }

        [QO("type_id")]
        public int? TypeID { get; set; }

        [QO("udf_pulldown_1_id")]
        public int? UserDefinedField1 { get; set; }

        [QO("udf_pulldown_2_id")]
        public int? UserDefinedField2 { get; set; }

        [QO("udf_pulldown_3_id")]
        public int? UserDefinedField3 { get; set; }

        [QO("limit_records_start")]
        public int? LimitRecordsStart { get; set; }

        [QO("limit_records_per_page")]
        public int? LimitRecordsPerPage { get; set; }

        [QO("order_by_1")]
        public string OrderBy1 { get; set; }

        [QO("order_by_2")]
        public string OrderBy2 { get; set; }

        [QO("order_by_3")]
        public string OrderBy3 { get; set; }

        [QO("order_by_1_sort")]
        public string OrderBy1Sort { get; set; }

        [QO("order_by_2_sort")]
        public string OrderBy2Sort { get; set; }

        [QO("order_by_3_sort")]
        public string OrderBy3Sort { get; set; }
    }
}