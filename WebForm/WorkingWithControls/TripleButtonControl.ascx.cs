using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithControls
{
    public class ButtonCountResult
    {
        public Int32 Index { get; set; }
        public Int32 Count { get; set; }
    }

    public partial class TripleButtonControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Int32 index;
            if (IsPostBack && Int32.TryParse(Request.Form["button"], out index))
            {
                GetClickCounts()[index].Count++;
            }
        }

        public ButtonCountResult[] GetClickCounts()
        {
            ButtonCountResult[] data;
            if ((data = (ButtonCountResult[])Session["triple_data"]) == null)
            {
                Session["triple_data"] = data = new ButtonCountResult[3];
                for (Int32 i = 0; i < data.Count(); i++)
                {
                    data[i] = new ButtonCountResult() { Index = i };
                }
            }
            return data;
        }
    }
}