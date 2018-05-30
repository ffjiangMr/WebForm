using System;
using System.Web;

namespace Handlers
{

    public class TotalDurationHandlerArgs : EventArgs
    {
        public Double TotalTime { get; set; }
        public Int32 Requests { get; set; }
    }

    public class TotalDurationModule : IHttpModule
    {

        private Double totalTIme = 0;
        private Int32 requestCount = 0;

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
            //context.LogRequest += new EventHandler(OnLogRequest);
            context.PreRequestHandlerExecute += this.HandleEvent;
            context.PostRequestHandlerExecute += this.HandleEvent;
        }

        private void HandleEvent(Object sender, EventArgs args)
        {
            HttpContext context = ((HttpApplication)sender).Context;
            if (!context.IsPostNotification)
            {
                context.Items["total_time"] = this.totalTIme;
            }
            else if (context.Handler is IRequiresDurationData)
            {
                totalTIme = (Double)context.Items["total_time"];
                requestCount++;
                System.Diagnostics.Debug.Write(String.Format($"Total Duration is {totalTIme}ms for {requestCount} requests"));
            }
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //custom logging logic can go here
        }
    }
}
