using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AsyncApp
{

    public class WebSiteResult
    {
        public String Url { get; set; }
        public Int64 Length { get; set; }
        public Int64 Blocked { get; set; }
        public Int64 Total { get; set; }
    }

    public partial class Default : System.Web.UI.Page
    {
        private WebSiteResult result;

        protected void Page_Load(object sender, EventArgs e)
        {
            String targetUrl = "http://asp.net";
            WebClient client = new WebClient();
            result = new WebSiteResult { Url = targetUrl };
            Stopwatch sw = Stopwatch.StartNew();
            RegisterAsyncTask(new PageAsyncTask(async () =>
            {
                String webContent = await client.DownloadStringTaskAsync(targetUrl);
                result.Length = webContent.Length;               
                result.Total = (Int64)DateTime.Now.Subtract(Context.Timestamp).TotalMilliseconds;
            }));
            result.Blocked = sw.ElapsedMilliseconds;
        }

        public WebSiteResult GetResult()
        {
            return result;
        }
    }
}