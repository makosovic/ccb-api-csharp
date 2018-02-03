using System;
using ChurchCommunityBuilder.Api.Attributes;

namespace ChurchCommunityBuilder.Api.Financial.QueryObject
{
    public class BatchQO : ChurchCommunityBuilder.Api.QueryObject
    {
        [QO("modified_since")]
        public DateTime? ModifiedSince { get; set; }
    }
}
