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
                if ((action == "login") && Membership.ValidateUser(user,password))
                {
                    FormsAuthentication.RedirectFromLoginPage(user, false);
                }
                else
                {
                    //Membership.CreateUser("Joe", "secret","joe@apress.com","What month were you born?" ,"January",false,out _);
                    //Membership.CreateUser("Jacqui", "supersecret", "jacqui@apress.com", "What is your favorite color?", "Green", false, out _);
                    //Membership
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