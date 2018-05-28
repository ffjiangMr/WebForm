using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handlers
{
    public class InstantiationControlFactory : IHttpHandlerFactory
    {
        private Int32 factoryCounter = 0;

        public IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated)
        {
            return new InstanceControlHander(++factoryCounter);
        }

        public void ReleaseHandler(IHttpHandler handler)
        {
           // TODO
           // 处理程序完成处理后调用
        }        
    }

    public class InstanceControlHander : IHttpHandler
    {

        private Int32 handlerCounter;

        public InstanceControlHander(Int32 count)
        {
            this.handlerCounter = count;
        }

        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(String.Format($"The counter value is {this.handlerCounter}"));
        }
    }
}