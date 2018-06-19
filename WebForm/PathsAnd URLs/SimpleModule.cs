using System;
using System.Diagnostics;
using System.Web;

namespace PathsAndURLs
{
    public class SimpleModule : IHttpModule
    {
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
            context.BeginRequest += (src, args) => { ProcessRequest(context); };
        }

        private void ProcessRequest(HttpApplication app)
        {
            if (app.Request.FilePath == "/Test.aspx")
            {
                app.Server.Transfer("Content/RequestReporter.aspx");
            }
            WriteMsg("URL requested: {0} {1}", app.Request.RawUrl, app.Request.FilePath);
        }

        private void WriteMsg(String formatString, params Object[] vals)
        {
            Debug.WriteLine(formatString,vals);
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //custom logging logic can go here
        }
    }
}
