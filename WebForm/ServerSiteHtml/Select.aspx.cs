using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace ServerSiteHtml
{
    public partial class Select : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlSelect select = new HtmlSelect { ID = "colorSelect2" };
            select.Items.Add(new ListItem { Text = "Red", Value = "red" });
            select.Items.Add(new ListItem { Text = "Green", Value = "green", Selected = true });
            select.Items.Add(new ListItem { Text = "Red", Value = "red" });
            container.Controls.Add(select);
        }
    }
}