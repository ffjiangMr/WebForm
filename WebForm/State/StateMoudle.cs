using System;
using System.Web;

namespace State
{

    public enum City
    {
        London,
        Paris,
        Chicage,
    }

    public enum Color
    {
        Red,
        Green,
        Blue,
    }

    public class StateMoudle : IHttpModule
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
            //context.LogRequest += new EventHandler(OnLogRequest);

            context.PostAcquireRequestState += (src, arg) =>
            {
                if ((context.Context.Session != null) &&
                    //(context.Context.Session.IsNewSession) &&
                    (!context.Context.Session.IsReadOnly)
                   )
                {
                    context.Context.Session["color"] = Color.Green;
                    context.Context.Session["city"] = City.London;
                }
            };
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //custom logging logic can go here
        }
    }
}
