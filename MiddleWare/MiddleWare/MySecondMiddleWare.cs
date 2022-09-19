using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleWare
{
    public class MySecondMiddleWare
    {
        private RequestDelegate next;
        public MySecondMiddleWare(RequestDelegate requestDelegate)
        {
            this.next = requestDelegate;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("\nI am in second Class based middle ware...");
            await next(httpContext);
        }
    }
}
