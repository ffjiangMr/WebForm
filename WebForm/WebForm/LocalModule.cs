using System;
using System.Threading;
using System.Web;

namespace WebForm
{
    public class LocalModule : IHttpModule
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

        public void Init(HttpApplication app)
        {
            // Below is an example of how you can handle LogRequest event and provide 
            // custom logging implementation for it
            app.LogRequest += new EventHandler(OnLogRequest);
            app.BeginRequest += HandleEvent;
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //custom logging logic can go here
        }

        protected void HandleEvent(Object sender, EventArgs args)
        {
            String[] langs = ((HttpApplication)sender).Request.UserLanguages;
            if ((langs != null) && (langs.Length > 0) && (langs[0] != null))
            {
                try
                {
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(langs[0]);
                }
                catch (Exception e)
                {

                }
            }
        }
    }
}
