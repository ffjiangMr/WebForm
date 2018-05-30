using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;

namespace WebForm
{
    public class WebFormHandlerFactory : IHttpHandlerFactory
    {
        public IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated)
        {
            Page page = BuildManager.CreateInstanceFromVirtualPath(context.Request.Path, typeof(Page)) as Page;

            context.Response.Write(String.Format($"<div style=\"padding = 10 px;background-color=lightgrey;border=thin solid black \"> Context form {context.Request.Path} </div>"));
            return page;
        }

        public void ReleaseHandler(IHttpHandler handler)
        {
           //TODO
        }
    }
}