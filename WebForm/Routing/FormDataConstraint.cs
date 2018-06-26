using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Routing
{
    public class FormDataConstraint : IRouteConstraint
    {
        private String targetValue;

        public FormDataConstraint(String value)
        {
            targetValue = value;
        }


        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            String actualValue = httpContext.Request.Form[parameterName];
            return actualValue != null && actualValue == targetValue;
        }
    }
}