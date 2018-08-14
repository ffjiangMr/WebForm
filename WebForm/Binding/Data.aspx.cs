using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Binding.Controls;
using System.Web.ModelBinding;

namespace Binding
{
    public partial class Data : System.Web.UI.Page
    {

        private Int32 maxValue;
        private String operation;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                maxValue = Int32.Parse(max.Value);
                OperationSelector selector = FindControl("opSelector") as OperationSelector;
                if (selector != null)
                {
                    operation = selector.SelectOperator;
                }
            }
        }

        public IEnumerable<String> GetData([Form("max")] Int32? maxValue, [Control("opSelector","SelectedOperator")] String operation)
        {
            if (operation != null)
            {
                for (Int32 i = 1; i < maxValue; i++)
                {
                    var op = operation == "Add" ? "+" : "-";
                    var value = operation == "Add" ? maxValue + i : maxValue - i;
                    yield return $"{maxValue}{op}{i}={value}";
                }
            }
        }
    }
}