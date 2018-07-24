using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controls.Custom
{
    public partial class BasicCacl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod=="POST")
            {
                Int32 firstVal = Int32.Parse(GetFormValue("firstNumber"));
                Int32 secondVal = Int32.Parse(GetFormValue("secondNumber"));
                result.InnerText = (firstVal + secondVal).ToString();
            }
        }

        protected String GetFormValue(String name)
        {
            return Request.Form[GetId(name)];
        }

        protected String GetId(String name)
        {
            return $"{ClientID}{ClientIDSeparator}{name}";
        }
    }
}