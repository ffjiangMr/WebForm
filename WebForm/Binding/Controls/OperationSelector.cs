using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Binding.Controls
{
    public class OperationSelector : WebControl
    {
        private String[] operators = { "Add", "Substract" };
        private String selectedOperator;

        public String SelectOperator
        {
            get
            {
                return selectedOperator ?? operators[0];
            }
        }

        public OperationSelector()
        {
            Init += (src, args) =>
            {
                if (Page.IsPostBack)
                {
                    OperationSelector op = Page.FindControl("opSelector") as OperationSelector;
                    if (op != null)
                    {
                        op.selectedOperator = Context.Request[GetFormId("op")];
                    }
                }
            };
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Name, GetFormId("op"));
            writer.RenderBeginTag(HtmlTextWriterTag.Select);
            foreach (String op in operators)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Value, op);
                if (op == SelectOperator)
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Selected, "selected");
                }
                writer.RenderBeginTag(HtmlTextWriterTag.Option);
                writer.Write(op);
                writer.RenderEndTag();
            }
            writer.RenderEndTag();
        }

        private String GetFormId(String name)
        {
            return $"{ClientID}{ClientIDSeparator}{name}";
        }
    }
}