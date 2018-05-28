using System;
using System.Web;

namespace Handlers
{
    public class SelectionControlFactory : IHttpHandlerFactory
    {
        public IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated)
        {
            if (url.ToLower().StartsWith("/time"))
            {
                return new CurrentTimeHandler();
            }
            else
            {
                return new CurrentDayHandler();
            }
        }

        public void ReleaseHandler(IHttpHandler handler)
        {
            //TODO
        }
    }

    public class CurrentTimeHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(String.Format($"The time is {DateTime.Now.ToShortTimeString()}"));
        }
    }

    public class CurrentDayHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(String.Format($"Today is {DateTime.Now.ToShortDateString()}"));
        }
    }
}