using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Int32 countVal = (Int32)(Session["counter"] ?? 0);
            if (IsPostBack)
            {
                Session["counter"] = ++countVal;
            }
            counter.InnerText = countVal.ToString();
            //ControlUtils.EnumerateControls(this,true);
            ControlUtils.AddButtonClickHandler(this);
        }

        protected void ButtonClick(Object src, EventArgs args)
        {
            Int32 count = (Int32)(Session["ui_counter"] ?? 0);
            Session["ui_counter"] = ++count;
            uiLabel.Text = count.ToString();
        }
    }
}