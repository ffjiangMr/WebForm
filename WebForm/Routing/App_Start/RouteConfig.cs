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
            routes.RouteExistingFiles = true;
            //routes.MapPageRoute("oldToNew", "Loop.aspx", "~/Default.aspx", false, null, new RouteValueDictionary() { { "httpMethod", new HttpMethodConstraint("GET") } });
            //var wr = new Route("store/{target}",new PageRouteHandler("~/Default.aspx"));
            //wr.RouteExistingFiles = false;
            //routes.Add(wr);
            //routes.Add("stop", new Route("methodtest", new StopRoutingHandler()));
            //routes.Ignore("methodtest");
            routes.Add("browser", new BrowserRoute("browser", new Dictionary<Browser, String>() { { Browser.CHROME, "~/Calc.aspx" }, { Browser.IE10, "~/Loop.aspx" }, { Browser.OTHER, "~/Default.aspx" } }));
            routes.MapPageRoute("store", "store/{target}", "~/Default.aspx");
            routes.MapPageRoute("default", "", "~/Default.aspx");
            routes.Add("apress", new Route("apress", null, null, new RouteValueDictionary() { { "target", "http://apress.com" } }, new RedirectionRouteHandler()));
            routes.MapPageRoute("posttest", "methodtest", "~/PostTest.aspx", false, null, new RouteValueDictionary() { { "httpMethod", new HttpMethodConstraint("POST") }, { "city", new FormDataConstraint("London") } });
            routes.Add("stop", new Route("methodtest", null, new RouteValueDictionary { { "httpMethod", new HttpMethodConstraint("POST") } }, new StopRoutingHandler()));
            routes.Ignore("methodtest", new { httpMethod = new HttpMethodConstraint("POST") });
            routes.MapPageRoute("gettest", "methodtest", "~/GetTest.aspx", false, null, new RouteValueDictionary { { "httpMethod", new HttpMethodConstraint("GET", "PUT", "DELETE", "HEAD", "OPTIONS", "PATCH", "CONNECT") } });
            //routes.MapPageRoute("cart1", "cart", "~/Store/Cart.aspx");
            //routes.MapPageRoute("cart2", "app/shopping/finish", "~/Store/Cart.aspx");
            //routes.MapPageRoute("default1", "{app}/default", "~/Default.aspx", false, null, new RouteValueDictionary() { { "app", "accounts|billing|payments" } });
            //RouteValueDictionary constraints = new RouteValueDictionary {
            //    { "first","[0-9]*"},{"second","[0-9]*" },{ "operation" ,"plus|minus"}
            //};
            //routes.MapPageRoute("calc", "calc/{first}/{operation}/{second}", "~/Calc.aspx", false, null, constraints);
            //routes.MapPageRoute("calc1", "calc", "~/Calc.aspx");
            //routes.MapPageRoute("cacl2", "cacl/{first}/{second}/{operation}", "~/Calc.aspx", false, new RouteValueDictionary() { { "operation", "plus" } }, constraints);
            //routes.MapPageRoute("calc3", "calc/{operation}/{*numbers}", "~/Calc.aspx");
            //routes.MapPageRoute("loop", "{count}", "~/Loop.aspx", false, new RouteValueDictionary() { { "count", "3" } }, new RouteValueDictionary() { { "count", "[0-9]" } });
            //routes.MapPageRoute("out","out","~/Out.aspx");
        }
    }
}