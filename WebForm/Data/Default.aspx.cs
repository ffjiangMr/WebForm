using Data.Models;
using Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data
{

    public class CategoryView
    {
        public String Name { get; set; }
        public String Selected { get; set; }
    }

    public partial class Default : System.Web.UI.Page
    {

        public IEnumerable<Product> GetProductData([Control("dSelect", "Value")] String filterSelect)
        {
            var productData = new Repository().Products;
            return (String.IsNullOrEmpty(filterSelect) ? "All" : filterSelect) == "All" ? productData : productData.Where(p => p.Category == filterSelect);
        }

        public IEnumerable<Product> GetCategories()
        {
            return new Product[] { new Product { Category = "All" } }.Concat((new Repository().Products.GroupBy(p => p.Category).Select(g => g.FirstOrDefault()).OrderBy(c => c.Category)));
            //return new String[] { "All" }.Concat(new Repository().Products.Select(p => p.Category).Distinct().OrderBy(c => c));
            //.Select(c => new CategoryView()
            //{
            //    Name = c,
            //    Selected = (c == (filterSelect ?? "All") ? "selected='selected'" : null),                
            //});
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}