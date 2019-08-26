using Microsoft.AspNetCore.Builder;

namespace NotSteam.Core.Extensions
{
    public static class ApiCors
    {
        public static void UseApiCors(this IApplicationBuilder app)
        {
            app.UseCors(builder =>
            {
                builder.WithOrigins("http://localhost", "https://localhost")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        }
    }
}
