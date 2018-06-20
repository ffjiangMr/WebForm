using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PathsAnd_URLs
{
    public class ExtensionlessHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<p>Expressionless Handler</p>");
            String vPath = context.Request.Path;
            if (vPath == "/")
            {
                context.Server.Transfer("/Default.aspx");
            }
            else if (File.Exists(context.Request.MapPath(vPath + ".aspx")))
            {
                context.Server.Transfer(vPath + ".aspx");
            }
            else
            {
                context.Response.StatusCode = 404;
                context.ApplicationInstance.CompleteRequest();
            }
            
        }
    }
}