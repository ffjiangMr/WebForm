using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controls.Custom
{

    public enum OperationType
    {
        PLUS,
        MINU,
    }

    public class Calculation
    {
        public OperationType Operation { get; set; }
        public Int32 Value { get; set; }
    }

    public partial class BasicCacl : System.Web.UI.UserControl
    {

        public Int32 FirstValue { get; set; }

        public Int32 SecondValue { get; set; }

        public OperationType Operation { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                Int32 total = Int32.Parse(GetFormValue("initialVal"));
                String[] numbers = GetFormValue("calcValue").Split(',');
                String[] operators = GetFormValue("calcOp").Split(',');
                for (Int32 i = 0; i < operators.Length; i++)
                {
                    Int32 val = Int32.Parse(numbers[i]);
                    total += operators[i] == "PLUS" ? val : 0 - val;
                }
                result.InnerText = total.ToString();
                //FirstValue = Int32.Parse(GetFormValue("firstNumber"));
                //SecondValue = Int32.Parse(GetFormValue("secondNumber"));
                //result.InnerText = ((Operation == OperationType.PLUS)
                //                     ? (FirstValue + SecondValue)
                //                     : (FirstValue - SecondValue)).ToString();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"ID:{result.ID},UniqueID:{result.UniqueID}");
            }
        }

        public List<Calculation> Calculations { get; set; }

        public List<Calculation> GetCalculations()
        {
            return Calculations;
        }

        public Int32 Initial { get; set; }

        protected String GetFormValue(String name)
        {
            return Request.Form[GetId(name)];
        }

        protected String GetId(String name)
        {
            return $"{ClientID}{ClientIDSeparator}{name}";
        }
    }
}