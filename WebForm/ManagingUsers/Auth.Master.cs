using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManagingUsers
{
    public partial class Auth : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.IsAuthenticated)
                {
                    authAction.InnerText = "Log Out";
                }
                else
                {
                    authGreeting.Visible = false;
                    authAction.InnerText = "Log In";
                }
            }
            else if(IsPostBack && (Request.Form["authAction"] == "auth")){
                if (Request.IsAuthenticated)
                {
                    FormsAuthentication.SignOut();
                    Response.Redirect(Request.Path);
                }
                else {
                    FormsAuthentication.RedirectToLoginPage();
                }
            }

        }

        protected String GetGreeting()
        {
            return $"Hello ,{Context.User.Identity.Name}";
        }
    }
}