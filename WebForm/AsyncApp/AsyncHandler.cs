using System;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace AsyncApp
{
    public class AsyncHandler : HttpTaskAsyncHandler
    {
        /// <summary>
        /// You will need to configure this handler in the Web.config file of your 
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        public override async Task ProcessRequestAsync(HttpContext context)
        {
            String webRespone = await new WebClient().DownloadStringTaskAsync("http://asp.net");
            context.Response.ContentType = "text/plain";
            context.Response.Write($"The length of the result is {webRespone.Length}");
        }

        #endregion
    }
}
