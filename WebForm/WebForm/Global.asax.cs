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

        public Global()
        {
            BeginRequest += this.HandleEvent;
            EndRequest += this.HandleEvent;
            LogRequest += this.HandleEvent;
            PreRequestHandlerExecute += this.HandleEvent;
            PostRequestHandlerExecute += this.HandleEvent;
        }

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

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Application, "End");
        }
    }
}