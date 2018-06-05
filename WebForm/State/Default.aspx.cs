using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO.Ports;
using System.Web.Profile;

namespace State
{
    public partial class Default : System.Web.UI.Page
    {
        //private Int32 counter = 0;
        private String user;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.user = Request.Form["requestedUser"] ?? "Joe";
        }

        protected Int32 GetCounter()
        {
            ProfileBase profile = ProfileBase.Create(this.user);
            Int32 counter = (Int32)(profile["counter"]);
            profile["counter"] = ++counter;
            profile.Save();
            //Application.Lock();
            //Int32 result = (Int32)(Application["counter"] ?? 0);
            //Application["counter"] = ++result;
            //Application.UnLock();
            return counter;
        }

        protected Int32 GetSessionCounter()
        {
            Int32 counter = (Int32)(Session["counter"] ?? 0);
            Session["counter"] = ++counter;
            return counter;
        }

    }
}