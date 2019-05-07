using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;


namespace CrossCutDemo.MiddlewareComponents
{

    public class RequestCultureMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestCultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //Get the culture from request Headers
            var cultureQuery = context.Request.Query["culture"];
            //Test on all Browsers
            //Also check for known browsers - User Agents can be http client application
            if (!string.IsNullOrWhiteSpace(cultureQuery))
            {
                var culture = new CultureInfo(cultureQuery);
                CultureInfo.CurrentCulture = culture;
                CultureInfo.CurrentUICulture = culture;
            }

            await _next(context);
        }

    }

    public static class RequestCultureMiddlewareExtensions
    {
        public static IApplicationBuilder useRequestCulture(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestCultureMiddleware>();       
        }
    }

}
