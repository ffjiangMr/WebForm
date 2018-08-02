using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Diagnostics;
using System.Web.UI.WebControls;

namespace ServerSiteHtml
{
    public partial class Container : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            outerDiv.InnerText = "<b>This is the div element</b>";
        }

        protected void ProcessContainerControl(HtmlContainerControl c)
        {
            Boolean isLiteral = IsLiteralContent(c);
            String innerText = isLiteral ? c.InnerText.Trim() : "N / A";
            Debug.WriteLine($"ID:{c.ID} Literal:{isLiteral}, innerText:{innerText}");
            foreach (Control child in c.Controls)
            {
                if (child is HtmlContainerControl)
                {
                    this.ProcessContainerControl(child as HtmlContainerControl);
                }
            }
        }

        protected Boolean IsLiteralContent(HtmlContainerControl c)
        {
            return (c.Controls != null) && (c.Controls.Count == 1) && (c.Controls[0] is LiteralControl);
        }
    }
}