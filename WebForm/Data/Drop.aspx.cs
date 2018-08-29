using Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data
{
    public partial class Drop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                selection.InnerText = drop.SelectedValue;
            }
        }
        public IEnumerable<String> GetProducts()
        {
            return new Repository().Products.Select(item => item.Name);
        }
    }
}