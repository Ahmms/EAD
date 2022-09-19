using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleWare
{
    public class MyMiddleware
    {
        private RequestDelegate next;
        public MyMiddleware(RequestDelegate requestDelegate)
        {
            this.next = requestDelegate;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("I am in Class based middle ware...");
            await next(httpContext);
        }
    }
}
