using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSiteHtml
{
    public partial class BaseClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userInput.Attributes["class"] = "user";
            foreach (var item in userInput.Attributes.Keys)
            {
                Debug.WriteLine($"Attribute {item}:{userInput.Attributes["item"]}");
            }
            Debug.WriteLine($"TagName :{userInput.TagName}");
        }
    }
}