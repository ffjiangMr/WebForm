using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ErrorHandling
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack && (Request.Form["pageAction"] == "error"))
            {
                throw new ArgumentNullException();
            }
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            if (Context.Error is FormatException)
            {
                Response.Redirect($"/ComponentError.aspx?errorSource={Request.Path}&errorType={Context.Error.GetType()}");
            }
        }
    }
}