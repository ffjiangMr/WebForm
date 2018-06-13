using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caching
{
    public partial class CitiedForm : System.Web.UI.Page
    {
        private static readonly String fileName = "/CitiesList.html";
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AddFileDependency(MapPath(fileName));
        }

        protected String GetCities()
        {
            return File.ReadAllText(MapPath(fileName));
        }
    }
}