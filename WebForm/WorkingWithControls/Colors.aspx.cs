using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WorkingWithControls
{
    public partial class Colors : System.Web.UI.Page
    {
        private String[] colors = { "Red", "Green", "Bule" };
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlGenericControl div = FindControl("buttonTarget") as HtmlGenericControl;
        }
    }
}