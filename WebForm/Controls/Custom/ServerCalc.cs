using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controls.Custom
{
    public class ServerCalc : WebControl
    {
        private Int32? total = null;

        public Int32 Initial { get; set; }
        public List<Calculation> Calculations { get; set; }

        public ServerCalc()
        {
            Load += (src, args) =>
            {
                if (Context.Request.HttpMethod == "POST")
                {
                    total = Int32.Parse(GetFormValue("initialVal"));
                    String[] numbers = GetFormValue("calcValue").Split(',');
                    String[] operators = GetFormValue("calcOp").Split(',');
                    for (Int32 i = 0; i < operators.Length; i++)
                    {
                        Int32 val = Int32.Parse(numbers[i]);
                        total += operators[i] == "PLUS" ? val : 0 - val;
                        Calculations[i].Value = val;
                    }
                }
            };
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.Write("This is the ServerCalc control");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            writer.AddAttribute(HtmlTextWriterAttribute.Name, GetId("initialVal"));
            writer.AddAttribute(HtmlTextWriterAttribute.Value, Initial.ToString());
            writer.RenderBeginTag(HtmlTextWriterTag.Input);                        
            writer.RenderEndTag();
            foreach (Calculation calc in Calculations)
            {
                writer.Write(calc.Operation == OperationType.PLUS ? "+" : "-");                
                writer.AddAttribute(HtmlTextWriterAttribute.Name, GetId("calcValue"));
                writer.AddAttribute(HtmlTextWriterAttribute.Value, calc.Value.ToString());
                writer.RenderBeginTag(HtmlTextWriterTag.Input);             
                writer.RenderEndTag();                
                writer.AddAttribute(HtmlTextWriterAttribute.Type, "hidden");
                writer.AddAttribute(HtmlTextWriterAttribute.Name, GetId("calcOp"));
                writer.AddAttribute(HtmlTextWriterAttribute.Value, calc.Operation.ToString());
                writer.RenderBeginTag(HtmlTextWriterTag.Input);
                writer.RenderEndTag();
            }
            writer.Write(" ");            
            writer.AddAttribute(HtmlTextWriterAttribute.Type, "submit");
            writer.RenderBeginTag(HtmlTextWriterTag.Button);            
            writer.Write("=");
            writer.RenderEndTag();
            if (total.HasValue)
            {
                writer.Write(" " + total.Value);
            }            
            writer.RenderEndTag();
            //base.RenderContents(writer);
        }

        protected String GetFormValue(String name)
        {
            return Context.Request.Form[GetId(name)];
        }

        protected String GetId(String name)
        {
            return $"{ClientID}{ClientIDSeparator}{name}";
        }
    }
}