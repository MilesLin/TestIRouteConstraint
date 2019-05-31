using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using TestIRouteConstraint.Services;

namespace TestIRouteConstraint.App_Start
{
    public class CmsUrlConstraint : IRouteConstraint
    {
        public bool Match(
            HttpContextBase httpContext, 
            Route route, 
            string parameterName, 
            RouteValueDictionary values, 
            RouteDirection routeDirection)
        {
            // 網址輸入 http://localhost:52572/market 就會進入到 NavService 的地方
            if (values[parameterName] == null)
            {
                return false;
            }

            var navService = new NavService();

            var path = navService.GetNav().Result;

            return path == "market";
        }
    }
}