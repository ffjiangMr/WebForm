using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class Basic : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public String DisplayList(String[] dataItems)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in dataItems)
            {
                sb.AppendFormat($"<li>{item}</li>");
            }
            return sb.ToString();
        }


    }
}