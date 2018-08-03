using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Diagnostics;
namespace ServerSiteHtml
{
    public partial class SimpleForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (Control c in Form.Controls)
            {
                HtmlInputControl ic = c as HtmlInputControl;
                if (ic != null)
                {
                    Debug.WriteLine($"Name :{ic.Name}, value:{ic.Value}");
                }
            }
        }
    }
}