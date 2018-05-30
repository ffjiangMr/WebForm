using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class PostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            firstPH.Visible = !(secondPH.Visible = IsPostBack);
            if (IsPostBack)
            {
                Int32 firstNum = Int32.Parse(firstNumber.Value);
                Int32 secondNum = Int32.Parse(secondNumber.Value);
                result.InnerText = (firstNum + secondNum).ToString();
            }
        }
    }
}