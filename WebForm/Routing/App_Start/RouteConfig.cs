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
            routes.MapPageRoute("default", "", "~/Default.aspx");
            routes.MapPageRoute("cart1", "cart", "~/Store/Cart.aspx");
            routes.MapPageRoute("cart2", "app/shopping/finish", "~/Store/Cart.aspx");
            routes.MapPageRoute("default1", "{app}/default", "~/Default.aspx", false, null, new RouteValueDictionary() { { "app", "accounts|billing|payments" } });
            RouteValueDictionary constraints = new RouteValueDictionary {
                { "first","[0-9]*"},{"second","[0-9]*" },{ "operation" ,"plus|minus"}
            };
            routes.MapPageRoute("calc", "calc/{first}/{operation}/{second}", "~/Calc.aspx", false, null, constraints);
            routes.MapPageRoute("calc1", "calc", "~/Calc.aspx");
            routes.MapPageRoute("cacl2", "cacl/{first}/{second}/{operation}", "~/Calc.aspx", false, new RouteValueDictionary() { { "operation", "plus" } }, constraints);
            routes.MapPageRoute("calc3", "calc/{operation}/{*numbers}", "~/Calc.aspx");
            routes.MapPageRoute("loop", "{count}", "~/Loop.aspx", false, new RouteValueDictionary() { { "count", "3" } }, new RouteValueDictionary() { { "count", "[0-9]" } });
            routes.MapPageRoute("out","out","~/Out.aspx");
        }
    }
}