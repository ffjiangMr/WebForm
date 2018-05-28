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

            String time = DateTime.Now.ToShortTimeString();

            if (IsAjaxRequest(context.Request))
            {
                context.Response.ContentType = "application/json";
                context.Response.Write(String.Format($"time {time}"));
            }
            else
            {
                context.Response.ContentType = "text/html";
                context.Response.Write(String.Format($"<span>{time}</span>"));
            }

            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
        }

        private Boolean IsAjaxRequest(HttpRequest request)
        {
            return (request.Headers["X-Requested-With"] == "XMLHttpRequest") ||
                    (request["X-Requested-With"] == "XMLHttpRequest");
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