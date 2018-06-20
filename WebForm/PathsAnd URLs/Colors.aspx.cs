using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PathsAnd_URLs
{
    public partial class Colors : System.Web.UI.Page
    {

        public IEnumerable<String> GetColors()
        {
            return Request.GetFriendlyUrlSegments();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}