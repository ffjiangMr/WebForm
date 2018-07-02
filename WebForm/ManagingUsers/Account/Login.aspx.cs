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
                    FormsAuthentication.SetAuthCookie(user, false);
                }
                else
                {
                    FormsAuthentication.SignOut();
                }
                Response.Redirect(Request.Path);
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