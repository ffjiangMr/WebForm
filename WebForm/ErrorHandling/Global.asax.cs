using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ErrorHandling
{

    public enum Failure
    {
        None,
        Database,
        FileSystem,
        Network,
    }

    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Failure failReason = CheckForRootCause();
            if (failReason != Failure.None)
            {
                Response.ClearHeaders();
                Response.ClearContent();
                Response.StatusCode = 200;
                Server.Execute($"/ComponentError.aspx?errorSource={failReason.ToString().ToLower()}&errorType={Context.Error.GetType()}");
                Context.ClearError();
                //Response.Redirect($"/ComponentError.aspx?errorSource={failReason.ToString().ToLower()}&errorType={Context.Error.GetType()}");
            }
            Debug.WriteLine($"Failure: {failReason},Exception Type : {Context.Error.GetType()}");
        }

        private Failure CheckForRootCause()
        {
            Array values = Enum.GetValues(typeof(Failure));
            return (Failure)values.GetValue(new Random().Next(values.Length));
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}