using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlState.Custom
{
    public class SimpleTime : WebControl
    {
        private String timeStamp;
        private Boolean stateful;
        public SimpleTime()
        {
            Load += (src, args) =>
            {
                if ((timeStamp = ViewState["time"] as String) != null)
                {
                    stateful = true;
                }
                else
                {
                    timeStamp = DateTime.Now.ToLongTimeString();
                }
            };
            PreRender += (src, args) =>
            {
                ViewState["time"] = DateTime.Now.ToLongTimeString();
            };
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            String flag = this.stateful ? " State" : " New";
            writer.Write($"time{timeStamp}{flag}");
            writer.RenderEndTag();
        }
    }
}