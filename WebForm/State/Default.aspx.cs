using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO.Ports;

namespace State
{
    public partial class Default : System.Web.UI.Page
    {
        private Int32 counter = 0;
        private String user;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected Int32 GetCounter()
        {
            Application.Lock();
            Int32 result = (Int32)(Application["counter"] ?? 0);
            Application["counter"] = ++result;
            Application.UnLock();
            return result;
        }

    }
}