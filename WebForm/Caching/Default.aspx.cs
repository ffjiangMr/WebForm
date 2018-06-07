using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caching
{
    public partial class Default : System.Web.UI.Page
    {
        private static readonly String CACHE_KEY = "codebehind_ts";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected String GetTime()
        {
            String ts = (String)Cache[CACHE_KEY];
            if (ts == null)
            {
                Cache[CACHE_KEY] = ts = DateTime.Now.ToLongTimeString();
            }
            else
            {
                ts +=  "<b>(Cache)</b>";
            }
            return ts;
        }
    }
}