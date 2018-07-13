using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AsyncApp
{
    public class MultiWebSiteResult
    {
        public String Url { get; set; }
        public Int64 Length { get; set; }
        public Int64 StartTime { get; set; }
    }

    public partial class Multiples : System.Web.UI.Page
    {
        private ConcurrentQueue<MultiWebSiteResult> results;

        protected void Page_Load(object sender, EventArgs e)
        {
            String[] targetUrls = { "http://asp.net", "https://baidu.com", "http://amazon.com" };
            results = new ConcurrentQueue<MultiWebSiteResult>();

            RegisterAsyncTask(new PageAsyncTask(async () =>
            {
                List<Task> tasks = new List<Task>();
                foreach (String targetUrl in targetUrls)
                {
                    tasks.Add(Task.Factory.StartNew(() =>
                    {
                        MultiWebSiteResult result = new MultiWebSiteResult() { Url = targetUrl };
                        results.Enqueue(result);
                        result.StartTime = (Int64)DateTime.Now.Subtract(Context.Timestamp).TotalMilliseconds;
                        Task<String> innerTask = new WebClient().DownloadStringTaskAsync(targetUrl);
                        innerTask.Wait();
                        result.Length = innerTask.Result.Length;                    
                    }));
                }
                await Task.WhenAll(tasks);
                rep.DataBind();
            }));
        }

        public IEnumerable<MultiWebSiteResult> GetResults()
        {
            return results;
        }

    }

}