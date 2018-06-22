using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Routing
{
    public partial class Out : System.Web.UI.Page
    {

        protected String GenerateURL()
        {
            return GetRouteUrl("cacl", new RouteValueDictionary() { { "first", "10" }, { "operation", "plus" }, { "second", "20" } });
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}