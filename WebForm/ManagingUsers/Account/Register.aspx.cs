using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManagingUsers.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                String username = Request["user"];
                String password = Request["pass"];
                String email = Request["email"];
                String question = Request["question"];
                String answer = Request["answer"];
                if (username == "" ||
                   password == "" ||
                   email == "" ||
                   answer == "")
                {
                    ReportError("All fields must be filled");
                }
                else
                {
                    MembershipCreateStatus status;
                    MembershipUser user = Membership.CreateUser(username, password, email, question, answer, true, out status);
                    if (status == MembershipCreateStatus.Success)
                    {
                        if (!Roles.RoleExists("users"))
                        {
                            Roles.CreateRole("users");
                        }
                        Roles.AddUserToRole(user.UserName, "users");
                        FormsAuthentication.SetAuthCookie(user.UserName, false);
                        Response.Redirect("/");
                    }
                    else
                    {
                        ReportError(status.ToString());
                    }
                }
            }
        }

        protected void ReportError(String errorMsg)
        {
            message.InnerText = "Error: " + errorMsg;
            error.Visible = true;
        }
    }
}