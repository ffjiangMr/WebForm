using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using Control = System.Web.UI.HtmlControls;

namespace ServerSiteHtml
{
    public partial class CreateTable : System.Web.UI.Page
    {
        private List<String[]> tableRows = new List<String[]>()
                                           {
                                               new String[]{"Red","2" },
                                               new String[]{"Greent","41" },
                                               new String[]{"Blue","3" },
                                           };

        protected void Page_Load(object sender, EventArgs e)
        {
            Control.HtmlTable table = new Control.HtmlTable();
            Control.HtmlTableRow headerRow = new Control.HtmlTableRow();
            headerRow.Cells.Add(new Control.HtmlTableCell("th") { InnerText = "Color" });
            headerRow.Cells.Add(new Control.HtmlTableCell("th") { InnerText = "Count" });
            table.Rows.Add(headerRow);
            foreach (String[] data in tableRows)
            {
                table.Rows.Add(new Control.HtmlTableRow
                {
                    Cells = {
                        new Control.HtmlTableCell{ InnerText = data[0]},
                        new Control.HtmlTableCell{ InnerText = data[1]},
                    }
                });
            }

            Control.HtmlTableRow footRow = new Control.HtmlTableRow();
            footRow.Cells.Add(new Control.HtmlTableCell("th") { InnerText = "Total" });
            footRow.Cells.Add(new Control.HtmlTableCell("th") { InnerText = "46" });
            table.Rows.Add(footRow);

            container.Controls.Add(table);
        }
    }
}