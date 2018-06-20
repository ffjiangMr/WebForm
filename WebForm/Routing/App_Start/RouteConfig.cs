using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("default","","~/Default.aspx");
            routes.MapPageRoute("cart1", "cart", "~/Store/Cart.aspx");
            routes.MapPageRoute("cart2", "app/shopping/finish", "~/Store/Cart.aspx");
            routes.MapPageRoute("default", "{app}/default", "~/Default.aspx",false,null,new RouteValueDictionary() { { "app","accounts|billing|payments"} });
        }
    }
}