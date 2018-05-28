using System;
using System.Collections.Concurrent;
using System.Web;

namespace Handlers
{
    public class RecyclingFactory : IHttpHandlerFactory
    {
        private BlockingCollection<RecyclingHandler> pool = new BlockingCollection<RecyclingHandler>();
        private Int32 handler_Count = 0;
        private Int32 handler_limit = 100;
        private Int32 totalRequests = 0;

        public Int32 TotalRequest => this.totalRequests;

        public IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated)
        {
            this.totalRequests++;
            RecyclingHandler handler;
            if (!pool.TryTake(out handler))
            {
                if (this.handler_Count < this.handler_limit)
                {
                    this.handler_Count++;
                    handler = new RecyclingHandler(this, this.handler_Count);
                    pool.Add(handler);
                }
                else
                {
                    pool.Take();
                }
            }
            handler.RequestCount++;
            return handler;
        }

        public void ReleaseHandler(IHttpHandler handler)
        {
            //TODO
            if (handler.IsReusable)
            {
                pool.Add((RecyclingHandler)handler);
            }
        }
    }

    public class RecyclingHandler : IHttpHandler
    {
        private Int32 handlerID;
        private RecyclingFactory factory;
        public Int32 RequestCount { get; set; }

        public bool IsReusable => this.RequestCount < 4;

        public RecyclingHandler(RecyclingFactory f, Int32 id)
        {
            factory = f;
            this.handlerID = id;
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(String.Format($"Total request:{factory.TotalRequest},HandlerIID:{handlerID},Handler Request{this.RequestCount}"));
        }
    }
}