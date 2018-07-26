using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace ControlState.Custom
{

    [Serializable]
    public class CounterControlState
    {        
        public Int32 LeftValue { get; set; }
        public Int32 RightValue { get; set; }
    }

    public partial class Counter : System.Web.UI.UserControl
    {

        public Int32 LeftValue { get; set; }
        public Int32 RightValue { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadStateData();
            String button = GetValue("button");
            if (button == GetId("left"))
            {
                LeftValue++;
            }
            else if (button == GetId("right"))
            {
                RightValue++;
            }
            SaveStateData();
        }

        private void LoadStateData()
        {
            CounterControlState state = ViewState["mystate"] as CounterControlState;
            if (state != null)
            {
                LeftValue = state.LeftValue;
                RightValue = state.RightValue;
            }
            //Int32 temp;
            //if (Int32.TryParse(GetValue("left"), out temp))
            //{
            //    LeftValue = temp;
            //}
            //if (Int32.TryParse(GetValue("right"), out temp))
            //{
            //    RightValue = temp;
            //}
            //LeftValue = (Session[GetSessionKey("left")] as Int32?) ?? LeftValue;
            //RightValue = (Session[GetSessionKey("reight")] as Int32?) ?? RightValue;
        }

        private void SaveStateData()
        {
            ViewState["mystate"] = new CounterControlState
            {
                LeftValue = this.LeftValue,
                RightValue = this.RightValue,
            };
        }

        protected String GetSessionKey(String name)
        {
            return $"{Request.Path}{IdSeparator}{GetId(name)}";
        }

        protected String GetValue(String name)
        {
            String id = GetId(name);
            return Request.Form[id] ?? Request[id];
        }

        protected String GetId(String name)
        {
            return $"{ClientID}{ClientIDSeparator}{name}";
        }
    }
}