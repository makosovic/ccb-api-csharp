using ChurchCommunityBuilder.Api.Entity;
using RestSharp;
using System.Linq;

namespace ChurchCommunityBuilder.Api.Extensions {
    public static class RestSharpExtensions {
        public static IChurchCommunityBuilderResponse ToChurchCommunityBuilderResponse(this IRestResponse restResponse) {
            var response = new ChurchCommunityBuilderResponse();

            response.StatusCode = restResponse.StatusCode;
            response.JsonResponse = restResponse.Content;

            if (restResponse.StatusCode != System.Net.HttpStatusCode.OK) {
                response.ErrorMessage = restResponse.ErrorMessage;
            }

            return response;
        }

        public static IChurchCommunityBuilderResponse<S> ToChurchCommunityBuilderResponse<S>(this IRestResponse<S> restResponse) where S : new() {
            var response = new ChurchCommunityBuilderResponse<S>();

            response.StatusCode = restResponse.StatusCode;
            response.JsonResponse = restResponse.Content;

            if (restResponse.Headers != null && restResponse.Headers.Count > 0) {
               if (restResponse.Headers.Any(x => x.Name == "X-RateLimit-Limit")) {
                    response.RateLimit = restResponse.Headers.First(x => x.Name == "X-RateLimit-Limit").Value.ToInt();
                }

                if (restResponse.Headers.Any(x => x.Name == "X-RateLimit-Remaining")) {
                    response.RateLimitRemaining = restResponse.Headers.First(x => x.Name == "X-RateLimit-Remaining").Value.ToInt();
                }

                if (restResponse.Headers.Any(x => x.Name == "X-RateLimit-Reset")) {
                    response.RateLimitReset = new System.DateTime(restResponse.Headers.First(x => x.Name == "X-RateLimit-Reset").Value.ToLong());
                }

                if (restResponse.Headers.Any(x => x.Name == "Retry-After")) {
                    response.RetryAfter = restResponse.Headers.First(x => x.Name == "Retry-After").Value.ToInt();
                }
            }

            if ((int)restResponse.StatusCode >= 300) {
                response.ErrorMessage = restResponse.ErrorMessage;
            }
            else {
                response.Data = restResponse.Data;
            }
            return response;
        }

        public static IChurchCommunityBuilderResponse<S> ToChurchCommunityBuilderResponse<S>(this IRestResponse<S> restResponse, string requestInput) where S : new() {
            var response = restResponse.ToChurchCommunityBuilderResponse();
            response.RequestValue = requestInput;
            return response;
        }
    }
}
