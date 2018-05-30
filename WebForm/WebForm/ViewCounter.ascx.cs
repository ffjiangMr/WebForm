using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{

    public class ViewCounterEventArgs : EventArgs
    {
        public Int32 Counter { get; set; }
    }

    public partial class ViewCounter : System.Web.UI.UserControl
    {

        public event EventHandler<ViewCounterEventArgs> Count;

        protected void Page_Load(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Control, "Load");
            Int32 count;
            if (!Int32.TryParse(Session["counter"]?.ToString(), out count))
            {
                count = 0;
            }
            Session["counter"] = ++count;
            if (Count != null)
            {
                Count(this, new ViewCounterEventArgs() { Counter = count });
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Control, "Init");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Control, "PreRender");
        }

        protected override void Render(HtmlTextWriter writer)
        {
            EventCollection.Add(EventSource.Control, "Render");
            base.Render(writer);
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Control, "Unload");
        }

        protected Int32? GetCounter()
        {
            return Session["counter"] as Int32? ?? 0;
        }

    }
}