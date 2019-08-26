using System.Collections.Generic;
using System.Net;

namespace NotSteam.Core.ApiResponse
{
    public class ApiErrorResponse : ApiResponse
    {
        public new bool Success { get; set; } = false;
        public ICollection<ApiErrorInformation> Errors { get; set; }

        public static ApiResponse Error(HttpStatusCode statusCode, ICollection<ApiErrorInformation> errors)
        {
            var response = new ApiErrorResponse()
            {
                Code = statusCode,
                Errors = errors
            };

            return response;
        }

        public static ApiResponse Error(HttpStatusCode statusCode, ApiErrorInformation error)
        {
            var errors = new List<ApiErrorInformation>() { error };

            return Error(statusCode, errors);
        }
    }
}
