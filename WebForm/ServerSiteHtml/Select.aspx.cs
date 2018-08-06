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
    public partial class Select : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlSelect select = new HtmlSelect { ID = "colorSelect2" };
            select.Items.Add(new ListItem { Text = "Red", Value = "red" });
            select.Items.Add(new ListItem { Text = "Green", Value = "green", Selected = true });
            select.Items.Add(new ListItem { Text = "Blue", Value = "blue" });
            container.Controls.Add(select);
            if (IsPostBack)
            {
                Debug.WriteLine($"colorSelect:{colorSelect.Value}");
                Debug.WriteLine($"colorSelect:{colorSelect.Items[colorSelect.SelectedIndex].Text}");
                Debug.WriteLine($"colorSelect2:{Request.Form["colorSelect2"]}");
            }
        }
    }
}