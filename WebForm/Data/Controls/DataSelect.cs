using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data.Controls
{
    public class DataSelect : DataBoundControl, INamingContainer
    {
        private Object[] dataArray;

        [TemplateContainer(typeof(ElementItem))]
        public ITemplate ItemTemplate { get; set; }

        public DataSelect()
        {
            Load += (src, args) =>
            {
                dataArray = ViewState["data"] as Object[];
                if (dataArray == null)
                {
                    DataBind();
                    dataArray = ViewState["data"] as Object[];
                }
            };
            Init += (src, args) =>
            {
                //ViewStateMode = System.Web.UI.ViewStateMode.Disabled;
            };
        }

        public String Value
        {
            get { return Context.Request.Form[GetId("customSelect")]; }
        }

        protected override void PerformDataBinding(IEnumerable data)
        {
            //dataArray = data.Cast<String>().ToArray();
            ViewState["data"] = data.Cast<Object>().ToArray();

        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Name, GetId("customSelect"));
            writer.RenderBeginTag(HtmlTextWriterTag.Select);
            for (Int32 flag = 0; flag < dataArray?.Length; flag++)
            {
                ElementItem elem = new ElementItem(flag, dataArray[flag]);
                elem.SelectedValue = Value;
                ItemTemplate.InstantiateIn(elem);
                elem.DataBind();
                elem.RenderControl(writer);
                //writer.AddAttribute(HtmlTextWriterAttribute.Value, dataArray[flag]);
                //if (((flag == 0) && (Value == null)) || dataArray[flag] == Value)
                //{
                //    writer.AddAttribute(HtmlTextWriterAttribute.Selected, "selected");
                //}
                //writer.RenderBeginTag(HtmlTextWriterTag.Option);
                //writer.Write(dataArray[flag]);
                //writer.RenderEndTag();
            }
            writer.RenderEndTag();
        }

        protected String GetId(String name)
        {
            return $"{ClientID}{ClientIDSeparator}{name}";
        }
    }

    public class ElementItem : Control, IDataItemContainer
    {

        public ElementItem(Int32 index, Object dataItem)
        {
            DataItemIndex = index;
            DataItem = dataItem;
        }

        public String SelectedValue { get; set; }

        public String GenerateSelect(String category)
        {
            return category == SelectedValue ? "selected" : null;
        }

        public object DataItem { get; set; }

        public int DataItemIndex { get; set; }

        public int DisplayIndex { get { return DataItemIndex; } }
    }
}