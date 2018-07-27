using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlState
{
    public partial class SimlpeState : System.Web.UI.Page
    {
        public Boolean? ViewStateWorks { get; set; }

        public Boolean? ControlStateWorks { get; set; }

        protected void Page_Init(Object sender, EventArgs args)
        {
            RegisterRequiresControlState(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                ViewStateWorks = ViewState["state"] != null;
            }
        }
    }
}