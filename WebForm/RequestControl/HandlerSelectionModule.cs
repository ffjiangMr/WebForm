﻿using System;
using System.Web;

namespace RequestControl
{
    public class HandlerSelectionModule : IHttpModule
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
            context.LogRequest += new EventHandler(OnLogRequest);
            context.PostResolveRequestCache += (src, args) =>
            {
                if (context.Request.RequestType == "POST")
                {
                    switch (context.Request.Form["choice"])
                    {
                        case "remamhandler":
                            context.Context.RemapHandler(new CurrentTimeHandler());
                            break;
                        case "execute":
                            String[] paths = { "Default.aspx", "SecondPage.aspx" };
                            foreach (var item in paths)
                            {
                                context.Response.Write(String.Format($"<div>This is the {item} response</div>"));
                                context.Server.Execute(item);
                            }
                            context.CompleteRequest();
                            break;
                    }
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
