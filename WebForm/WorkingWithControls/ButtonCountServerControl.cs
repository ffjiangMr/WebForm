using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithControls
{
    public class ButtonCountServerControl : WebControl
    {
        protected override void RenderContents(HtmlTextWriter output)
        {
            Int32 countVal = (Int32)(Page.Session["server_control_counter"] ?? 0);
            if (Page.IsPostBack && Page.Request.Form["button"] == "serverControl")
            {
                Page.Session["server_control_counter"] = ++countVal;
            }
            output.RenderBeginTag(HtmlTextWriterTag.Div);

            output.Write("Server Control Button presses: ");
            output.RenderBeginTag(HtmlTextWriterTag.Span);
            output.Write(countVal);
            output.RenderEndTag();
            output.RenderEndTag();

            output.RenderBeginTag(HtmlTextWriterTag.Div);
            output.RenderBeginTag(HtmlTextWriterTag.Button);
            output.AddAttribute(HtmlTextWriterAttribute.Name, "button");
            output.AddAttribute(HtmlTextWriterAttribute.Value, "serverControl");
            output.AddAttribute(HtmlTextWriterAttribute.Type, "submit");
            output.Write("Submit(Server Control)");
            output.RenderEndTag();

            output.RenderEndTag();
        }
    }
}