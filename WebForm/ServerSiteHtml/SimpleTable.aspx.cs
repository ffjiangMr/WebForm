using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ServerSiteHtml
{
    public partial class SimpleTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                IncrementCellValues(greenCell, totalCell);
            }
        }
        private void IncrementCellValues(params HtmlTableCell[] cells)
        {
            foreach (HtmlTableCell cell in cells)
            {
                cell.InnerText = (Int32.Parse(cell.InnerText) + 1).ToString();
            }
        }

    }
}