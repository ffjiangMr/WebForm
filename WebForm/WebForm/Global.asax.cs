using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebForm
{
    public class Global : System.Web.HttpApplication
    {

        private DateTime startTime;

        //public Global()
        //{
        //    BeginRequest += this.HandleEvent;
        //    EndRequest += this.HandleEvent;
        //    LogRequest += this.HandleEvent;
        //    PreRequestHandlerExecute += this.HandleEvent;
        //    PostRequestHandlerExecute += this.HandleEvent;
        //}

        protected void HandleEvent(Object sender, EventArgs e)
        {
            switch (Context.CurrentNotification)
            {
                case RequestNotification.BeginRequest:
                    EventCollection.Add(EventSource.Application, "BeginRequest");
                    //if (Request.RawUrl == "/Time")
                    //{
                    //    Response.Write(Context.Timestamp.ToLongTimeString());
                    //    CompleteRequest();
                    //}
                    if (Request.Browser.Browser.ToLower().IndexOf("chrome") == -1)
                    {
                        Response.SuppressContent = true;
                    }
                    break;
                default:
                    String eventName = Context.CurrentNotification.ToString();
                    EventCollection.Add(EventSource.Application, eventName);
                    break;
            }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Application, "Start");
            Application["message"] = "Application Event";
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            startTime = Context.Timestamp;
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_EndRequest(Object sender, EventArgs e)
        {
            double elapsed = DateTime.Now.Subtract(startTime).TotalMilliseconds;
            System.Diagnostics.Debug.WriteLine(String.Format($"Duration : {Request.RawUrl} {elapsed}ms"));
        }

        protected void Application_PostAuthenticateRequest(object sender, EventArgs e)
        {
            if ((Request.Url.LocalPath == "/Params.aspx") && (!User.Identity.IsAuthenticated))
            {
                Context.AddError(new UnauthorizedAccessException());
            }
        }

        protected void Application_LogRequest(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Request for {Request.RawUrl} - code {Response.StatusCode}");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Application, "End");
        }
    }
}