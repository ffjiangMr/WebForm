using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caching
{
    public class CityListInfo
    {
        public String Timetamp { get; set; }
        public String Html { get; set; }
    }

    public partial class CitiesControl : System.Web.UI.UserControl
    {
        private static readonly String fileName = "/CitiesList.html";
        private static readonly String CACHE_KEY = "cities_html";
        private CityListInfo cityInfo;
        private Boolean cached = false;

        public String GetCities()
        {
            return cityInfo.Html;
        }

        protected String GetTimeStamp()
        {
            return cityInfo.Timetamp;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            cityInfo = Cache[CACHE_KEY] as CityListInfo;
            if (cityInfo == null)
            {
                cityInfo = new CityListInfo()
                {
                    Timetamp = DateTime.Now.ToLongTimeString(),
                    Html = File.ReadAllText(MapPath(fileName)),
                };
                Cache.Insert(CACHE_KEY, cityInfo, new CacheDependency(MapPath(fileName)));
            }
            else
            {
                cached = true;
            }
        }
    }
}