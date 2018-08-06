using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Diagnostics;

namespace ServerSiteHtml
{
    public partial class HtmlTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                foreach (HtmlTableRow row in colorTable.Rows)
                {
                    foreach (HtmlTableCell cell in row.Cells)
                    {
                        if (cell.TagName == "td")
                        {
                            Debug.WriteLine($"cell:{cell.InnerText}");
                        }
                    }
                }
                HtmlTableCell green = colorTable.Rows[2].Cells[1];
                HtmlTableCell total = colorTable.Rows[4].Cells[1];
                IncrementCellValues(green,total);
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