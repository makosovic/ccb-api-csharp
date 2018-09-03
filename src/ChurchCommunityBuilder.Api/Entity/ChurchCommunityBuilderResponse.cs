using System;
using System.Net;

namespace ChurchCommunityBuilder.Api.Entity {
    public interface IChurchCommunityBuilderResponse {
        string RequestValue { get; set; }
        string JsonResponse { get; set; }
        HttpStatusCode StatusCode { get; set; }
        string ErrorMessage { get; set; }

        int RateLimit { get; set; }

        int RateLimitRemaining { get; set; }

        DateTime RateLimitReset { get; set; }

        int? RetryAfter { get; set; }
    }
    public interface IChurchCommunityBuilderResponse<T> : IChurchCommunityBuilderResponse {
        T Data { get; set; }
    }

    public class ChurchCommunityBuilderResponse : IChurchCommunityBuilderResponse {
        public string RequestValue { get; set; }

        public string JsonResponse { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string ErrorMessage { get; set; }

        public int RateLimit { get; set; }

        public int RateLimitRemaining { get; set; }

        public DateTime RateLimitReset { get; set; }

        public int? RetryAfter { get; set; }
    }

    public class ChurchCommunityBuilderResponse<T> : ChurchCommunityBuilderResponse, IChurchCommunityBuilderResponse<T> where T : new() {
        public T Data { get; set; }
    }
}
