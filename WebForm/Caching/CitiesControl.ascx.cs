using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caching
{
    public partial class CitiesControl : System.Web.UI.UserControl
    {
        private static readonly String fileName = "/CitiesList.html";

        public String GetCities()
        {
            return File.ReadAllText(MapPath(fileName)); 
        }

        protected String GetTimeStamp()
        {
            return DateTime.Now.ToLongTimeString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
    }
}