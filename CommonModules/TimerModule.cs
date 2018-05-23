using System;
using System.Web;

namespace CommonModules
{
    public class TimerModule : IHttpModule
    {

        private DateTime startTime;

        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Dispose()
        {
            //clean-up code here.
        }

        public void Init(HttpApplication context)
        {
            // Below is an example of how you can handle LogRequest event and provide 
            // custom logging implementation for it
            context.BeginRequest += HandleEvent;
            context.EndRequest += HandleEvent;
        }

        private void HandleEvent(Object sender, EventArgs args)
        {
            var app = sender as HttpApplication;
            switch(app.Context.CurrentNotification)
            {
                case RequestNotification.BeginRequest:
                    startTime = app.Context.Timestamp;
                    break;
                case RequestNotification.EndRequest:
                    double elapsed = DateTime.Now.Subtract(startTime).TotalMilliseconds;
                    System.Diagnostics.Debug.WriteLine($"Duration: {app.Request.RawUrl} {elapsed}ms.");
                    break;
                default:
                    break;
            }
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //custom logging logic can go here
        }
    }
}
