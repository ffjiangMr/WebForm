using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace Caching
{

    public class RequestEventMapMoudle : IHttpModule
    {
        public event EventHandler BeginRequest;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += (src, args) =>
            {
                if (BeginRequest != null)
                {
                    BeginRequest(this, EventArgs.Empty);
                }
            };
        }
    }

    public class RequestCountDependency:CacheDependency
    {
        private Int32 requestLimit, requestCount;

        public RequestCountDependency(Int32 limit)
        {
            this.requestLimit = limit;
            this.requestCount = 0;
            ConfigureEventHandler(true);
            FinishInit();
        }

        private void ConfigureEventHandler(Boolean attach)
        {
            if (HttpContext.Current != null)
            {
                RequestEventMapMoudle moudle = HttpContext.Current.ApplicationInstance.Modules["RequestEventMap"] as RequestEventMapMoudle;
                if (moudle != null)
                {
                    if (attach)
                    {
                        moudle.BeginRequest += this.HandleEvent;
                    }
                    else
                    {
                        moudle.BeginRequest -= this.HandleEvent;
                    }
                }
            }
        }

        private void HandleEvent(Object sender, EventArgs args)
        {
            if (++requestCount > requestLimit)
            {
                NotifyDependencyChanged(this, EventArgs.Empty);
            }
        }

        protected override void DependencyDispose()
        {
            ConfigureEventHandler(false);
            base.DependencyDispose();
        }

    }
}