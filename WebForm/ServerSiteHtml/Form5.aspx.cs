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
    public partial class Form5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlInputGenericControl rangeInput = new HtmlInputGenericControl("range") { ID = "userVal2" };
            rangeInput.Attributes["step"] = "5";
            rangeInput.Attributes["min"] = "50";
            rangeInput.Attributes["max"] = "100";
            inputContainer.Controls.Add(rangeInput);
            if (IsPostBack)
            {
                Debug.WriteLine($"Value 1:{userVal.Value}");
                Debug.WriteLine($"Value 2:{Request.Form["userVal2"]}");
            }
        }
    }
}