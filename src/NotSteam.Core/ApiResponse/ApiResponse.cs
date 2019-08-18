using System.Net;

namespace NotSteam.Core.ApiResponse
{
    public class ApiResponse
    {
        public bool Success { get; set; } = true;

        public HttpStatusCode Code { get; set; }

        public object Response { get; set; }

        public static ApiResponse Ok(object data)
        {
            return Ok(data);
        }

        public static ApiResponse Ok(HttpStatusCode statusCode, object data)
        {
            var response = new ApiResponse()
            {
                Code = statusCode,
                Response = data
            };

            return response;
        }
    }
}
