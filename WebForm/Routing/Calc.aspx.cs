using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Routing
{
    public partial class Calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Int32 firstNumber = 0;
            Int32 secondNumber = 0;
            String firstString = Request["first"];
            String secondString = Request["second"];
            String operationString = Request["operation"];
            if (RouteData.Values.Count > 0)
            {
                if (RouteData.Values.ContainsKey("number"))
                {
                    String[] elems = RouteData.Values["numbers"].ToString().Split('/');
                    firstString = elems[0];
                    secondString = elems[1];
                }
                else
                {
                    firstString = RouteData.Values["first"].ToString();
                    secondString = RouteData.Values["second"].ToString();
                }
                operationString = RouteData.Values["operation"].ToString();
            }

            else
            {
                firstString = Request["first"];
                secondString = Request["second"];
                operationString = Request["operation"];
            }

            if (!(String.IsNullOrEmpty(firstString) || String.IsNullOrEmpty(secondString) || String.IsNullOrEmpty(operationString)))
            {
                first.Value = firstString;
                second.Value = secondString;
                operation.Value = operationString;
                firstNumber = Int32.Parse(firstString);
                secondNumber = Int32.Parse(secondString);
                result.InnerText = (operationString == "plus" ?
                    firstNumber + secondNumber :
                    firstNumber - secondNumber).ToString();
                resultPh.Visible = true;

            }
        }
    }
}