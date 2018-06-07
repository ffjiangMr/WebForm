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
        private static readonly String TIME_CACHE_KEY = "cities_time";
        private static readonly String HTML_CACHE_KEY = "cities_html";
        private CityListInfo cityInfo;
        private Boolean cached = false;

        public String GetCities()
        {
            String html = (String)Cache[HTML_CACHE_KEY];
            if (html == null)
            {
                html = File.ReadAllText(MapPath(fileName));
                AggregateCacheDependency aggDep = new AggregateCacheDependency();
                aggDep.Add(new CacheDependency(MapPath(fileName)));
                aggDep.Add(new RequestCountDependency(3));
                Cache.Insert(HTML_CACHE_KEY, html,
                    //new CacheDependency(MapPath(fileName))
                    //new RequestCountDependency(3)
                    aggDep
                    );
            }
            else
            {
                cached = true;
            }
            return html;
        }

        protected String GetTimeStamp()
        {
            String timeStamp = (String)Cache[TIME_CACHE_KEY];
            if (timeStamp == null)
            {
                timeStamp = DateTime.Now.ToLongTimeString();
                Cache.Insert(TIME_CACHE_KEY, timeStamp, new CacheDependency(null, new String[] { HTML_CACHE_KEY }));
            }

            return timeStamp + (cached ? "<b>Cache</b>" : "");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //cityInfo = Cache[CACHE_KEY] as CityListInfo;
            //if (cityInfo == null)
            //{
            //    cityInfo = new CityListInfo()
            //    {
            //        Timetamp = DateTime.Now.ToLongTimeString(),
            //        Html = File.ReadAllText(MapPath(fileName)),
            //    };
            //    Cache.Insert(CACHE_KEY, cityInfo, new CacheDependency(MapPath(fileName)));
            //}
            //else
            //{
            //    cached = true;
            //}
        }
    }
}