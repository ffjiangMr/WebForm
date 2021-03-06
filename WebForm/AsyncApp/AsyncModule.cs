﻿using System;
using System.Net;
using System.Web;

namespace AsyncApp
{
    public class AsyncModule : IHttpModule
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
            EventHandlerTaskAsyncHelper helper = new EventHandlerTaskAsyncHelper(async (src,args)=> {
                if (context.Context.Request.Path == "/DisplayItemValue.aspx") {
                    String content = await new WebClient().DownloadStringTaskAsync("http://asp.net");
                    ((HttpApplication)src).Context.Items["length"] = content.Length;
                    
                }
            });
            context.AddOnBeginRequestAsync(helper.BeginEventHandler, helper.EndEventHandler);
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //custom logging logic can go here
        }
    }
}
