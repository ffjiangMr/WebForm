using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                Int32 firstVal = Int32.Parse(Request.Form["firstNumber"]);
                Int32 secondVal = Int32.Parse(Request.Form["secondNumber"]);
                //result.InnerText = (firstVal + secondVal).ToString();
            }
        }
    }
}