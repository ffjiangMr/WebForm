using System;
using System.Web;

namespace CommonModules
{
    public class LogModule : IHttpModule
    {
        public void Dispose()
        {
            //TODO
        }

        public void Init(HttpApplication app)
        {
            app.LogRequest += HandleEvent;
        }

        public void HandleEvent(Object sender, EventArgs args)
        {
            var app = sender as HttpApplication;
            System.Diagnostics.Debug.WriteLine($"Request for {app.Request.RawUrl} - code {app.Response.StatusCode}");

        }
    }
}
