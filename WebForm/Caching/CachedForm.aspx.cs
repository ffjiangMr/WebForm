using System;
using System.Web;

namespace Caching
{
    public partial class CachedForm : System.Web.UI.Page
    {
        private Double total = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                total = Double.Parse(quantity.Value) * Double.Parse(price.Value);
            }
        }

        protected String GetTotal()
        {
            return total == 0 ? "" : total.ToString("c");
        }

        protected String GetTimeStamp()
        {
            return DateTime.Now.ToLongTimeString();
        }

        protected static String GetDynamicTimeStamp(HttpContext context)
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}