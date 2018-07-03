using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManagingUsers.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                String user = Request["user"];
                String password = Request["password"];
                String action = Request["action"];
                if ((action == "login") && (user == "Joe") && (password == "secret"))
                {
                    FormsAuthentication.RedirectFromLoginPage(user, false);
                }
                else
                {
                    message.Style["visibility"] = "visible";
                    //FormsAuthentication.SignOut();
                    //Response.Redirect(Request.Path);
                }
                //Response.Redirect(Request.Path);
            }
            else if (Request.IsAuthenticated)
            {
                Response.StatusCode = 403;
                Response.SuppressContent = true;
                Context.ApplicationInstance.CompleteRequest();
            }
        }

        protected String GetUser()
        {
            return Context.User.Identity.Name;
        }

        protected Boolean GetRequestStatus()
        {
            return Request.IsAuthenticated;
        }
    }
}