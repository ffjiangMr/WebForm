using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data.Controls
{
    public class DataSelect : DataBoundControl
    {
        private String[] dataArray;

        public DataSelect()
        {
            Init += (src, args) =>
            {
                ViewStateMode = System.Web.UI.ViewStateMode.Disabled;
            };
        }

        public String Value
        {
            get { return Context.Request.Form[GetId("customSelect")]; }
        }

        protected override void PerformDataBinding(IEnumerable data)
        {
            dataArray = data.Cast<String>().ToArray();
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Name, GetId("customSelect"));
            writer.RenderBeginTag(HtmlTextWriterTag.Select);
            for (Int32 flag = 0; flag < dataArray.Length; flag++)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Value, dataArray[flag]);
                if (((flag == 0) && (Value == null)) || dataArray[flag] == Value)
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Selected,"selected");
                }
                writer.RenderBeginTag(HtmlTextWriterTag.Option);
                writer.Write(dataArray[flag]);
                writer.RenderEndTag();
            }
            writer.RenderEndTag();
        }

        protected String GetId(String name)
        {
            return $"{ClientID}{ClientIDSeparator}{name}";
        }
    }
}