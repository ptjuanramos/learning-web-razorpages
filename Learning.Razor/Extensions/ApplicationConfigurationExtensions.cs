using Learning.Razor.Middlewares;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.Razor.Extensions
{
    public static class ApplicationConfigurationExtensions
    {
        public static IApplicationBuilder UsePagesAccessLoggingMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<PagesAccessLoggingMiddleware>();
        }
    }
}
