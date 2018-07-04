using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManagingUsers.Account
{
    public partial class Change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            usernamePh.Visible = !Request.IsAuthenticated;
            oldpasswordPh.Visible = Session["oldpass"] == null;
            if (IsPostBack)
            {
                MembershipUser user = Request.IsAuthenticated ? Membership.GetUser() : Membership.GetUser(Request["user"]);
                String newpass = Request["newpass1"];
                if ((user == null) || (newpass != Request["newpass2"]) || (Server.HtmlEncode(newpass) != newpass))
                {
                    ReportError();
                }
                else
                {
                    try
                    {
                        user.ChangePassword((Session["oldpass"] ?? Request["oldpass"]).ToString(), newpass);
                        Session.Remove("oldpass");
                        FormsAuthentication.SignOut();
                        Response.Redirect(FormsAuthentication.LoginUrl);
                    }
                    catch (Exception ex)
                    {
                        ReportError();
                    }
                }
            }
        }

        protected void ReportError()
        {
            message.InnerText = "Error:Unkwon username or incorrect/invalid password";
            error.Visible = true;
        }
    }
}