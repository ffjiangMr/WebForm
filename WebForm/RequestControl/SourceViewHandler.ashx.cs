using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace RequestControl
{
    /// <summary>
    /// Summary description for SourceViewHandler
    /// </summary>
    public class SourceViewHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            String reqFilePath = context.Request.FilePath;
            reqFilePath = reqFilePath.Substring(0,reqFilePath.LastIndexOf('.'));
            if (reqFilePath.ToLower().EndsWith(".ashx"))
            {
                context.Response.Redirect(reqFilePath);
            }
            StreamReader reader = new StreamReader(context.Request.MapPath(reqFilePath));
            context.Response.ContentType = "text/plain";
            context.Response.Write("<pre>");
            context.Response.Write(context.Server.HtmlEncode(reader.ReadToEnd()));
            context.Response.Write("</pre>");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}