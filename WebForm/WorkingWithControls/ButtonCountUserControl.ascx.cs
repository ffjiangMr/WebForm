using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithControls
{
    public partial class ButtonCountUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Int32 countVal = (Int32)(Session["user_control_counter"] ?? 0);
            if (IsPostBack && Request.Form["button"] == "userControl")
            {
                Session["user_control_counter"] = ++countVal;
            }
            counter.InnerText = countVal.ToString();
        }
    }
}