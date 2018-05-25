using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handlers
{
    /// <summary>
    /// Summary description for Time
    /// </summary>
    public class Time : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}