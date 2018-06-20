using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PathsAnd_URLs
{
    public class PathMoudle : IHttpModule
    {
        private static readonly String[] extensions = { ".aspx", ".ashx" };
        public void Dispose()
        {
            //TODO
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += (src, args) => { HandleRequest(context); };
        }

        private void HandleRequest(HttpApplication app)
        {
            if (app.Request.CurrentExecutionFilePathExtension == String.Empty)
            {
                String target = null;
                String vPath = app.Request.CurrentExecutionFilePath;
                if (vPath == "/")
                {
                    target = "/Default.aspx";
                }
                else
                {
                    foreach (var item in extensions)
                    {
                        if (File.Exists(app.Request.MapPath(vPath + item)))
                        {
                            target = vPath + item;
                            break;
                        }

                    }
                }
                if (String.IsNullOrEmpty(target ))
                {
                    app.Context.RewritePath(target);
                }
            }
        }
    }
}