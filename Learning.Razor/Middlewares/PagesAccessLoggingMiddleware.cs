using Learning.Razor.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.Razor.Middlewares
{
    public class PagesAccessLoggingMiddleware
    {
        private readonly RequestDelegate nextMiddlewareInPipeLine;
        private readonly ILogger<PagesAccessLoggingMiddleware> middlewareLogger;

        public PagesAccessLoggingMiddleware(RequestDelegate nextMiddlewareInPipeLine, ILogger<PagesAccessLoggingMiddleware> middlewareLogger)
        {
            this.nextMiddlewareInPipeLine = nextMiddlewareInPipeLine;
            this.middlewareLogger = middlewareLogger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            string requestPath = httpContext.Request.Path;
            middlewareLogger.LogInformation($"Request path {requestPath}");

            string queryString = httpContext.Request.QueryString.ToString();
            if(!String.IsNullOrEmpty(queryString))
            {
                middlewareLogger.LogInformation($"Request parameters: {queryString}");
            }

            string requestBody = await httpContext.Request.Body.GetStringAsync();
            if(!String.IsNullOrEmpty(requestBody))
            {
                middlewareLogger.LogInformation($"Request body: {requestBody}");
            }

            //httpContext.Request.QueryString.
            await nextMiddlewareInPipeLine(httpContext);
        }
    }
}
