using Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data
{
    public partial class Check : System.Web.UI.Page
    {

        protected void Page_Init(Object sender, EventArgs e)
        {
            cbl.SelectedIndexChanged += (src, args) =>
            {
                List<String> selected = new List<String>();
                foreach(ListItem item in cbl.Items)
                {
                    if (item.Selected)
                    {
                        selected.Add(item.Value);
                    }
                }
                selection.InnerText = String.Join(",",selected);
            };
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<String> GetProducts()
        {
            return new Repository().Products.Select(item => item.Name);
        }
    }
}