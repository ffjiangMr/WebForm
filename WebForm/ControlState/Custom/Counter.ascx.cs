using System;

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

        protected void Page_Init(Object sender, EventArgs args)
        {
            Page.RegisterRequiresControlState(this);            
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                String button = GetValue("button");                
                if (button == GetId("left"))
                {
                    LeftValue++;
                }
                else if (button == GetId("right"))
                {
                    RightValue++;
                }
            }

            #region
            //LoadStateData();
            //String button = GetValue("button");
            //if (button == GetId("left"))
            //{
            //    LeftValue++;
            //}
            //else if (button == GetId("right"))
            //{
            //    RightValue++;
            //}
            //SaveStateData();
            #endregion

        }

        protected override object SaveControlState()
        {
            return new CounterControlState()
            {
                LeftValue = this.LeftValue,
                RightValue = this.RightValue,
            };
        }

        protected override void LoadControlState(object savedState)
        {
            CounterControlState state = savedState as CounterControlState;
            if (state != null)
            {
                LeftValue = state.LeftValue;
                RightValue = state.RightValue;
            }
        }

        protected override void LoadViewState(object savedState)
        {
            CounterControlState state = savedState as CounterControlState;
            if (state != null)
            {
                LeftValue = state.LeftValue;
                RightValue = state.RightValue;
            }
        }

        private void LoadStateData()
        {
            CounterControlState state = ViewState["mystate"] as CounterControlState;
            if (state != null)
            {
                LeftValue = state.LeftValue;
                RightValue = state.RightValue;
            }

            #region
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
            #endregion 

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