using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithForms
{
    public partial class MultiForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST" && Request.Form["button2"] != null)
            {
                resutl.InnerText = $"The city is {Request.Form["city"]}";
                city.Value = Request.Form["city"];
            }
            else if (Request.Form["button1"] != null)
            {
                resutl.InnerText = $"The color is {color.Text}";
            }

        }

        protected void ButtonClick(Object sender, EventArgs args)
        {
            resutl.InnerText = $"The color is {color.Text}";
        }
    }
}