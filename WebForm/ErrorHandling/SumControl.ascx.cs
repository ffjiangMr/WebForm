using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ErrorHandling
{
    public partial class SumControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Int32 first = Int32.Parse(Request.Form["first"]);
                Int32 second = Int32.Parse(Request.Form["second"]);
                result.InnerText = (first + second).ToString();
                resultPlaceholder.Visible = true;
            }
        }
    }
}