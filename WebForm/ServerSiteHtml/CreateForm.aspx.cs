using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace ServerSiteHtml
{
    public partial class CreateForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlInputText textInput = new HtmlInputText { ID = "name", Value = "Bob" };
            nameDiv.Controls.Add(textInput);

            HtmlInputPassword passInput = new HtmlInputPassword { ID = "pass", Value = "secret" };
            passDiv.Controls.Add(passInput);

            hiddenAndButtonDiv.InnerHtml = @"<input id='button' type='submit' value='Submit' />";
            HtmlInputHidden hiddenInput = new HtmlInputHidden { ID = "hiddenValue", Value = "true" };
            hiddenAndButtonDiv.Controls.Add(hiddenInput);
        }
    }
}