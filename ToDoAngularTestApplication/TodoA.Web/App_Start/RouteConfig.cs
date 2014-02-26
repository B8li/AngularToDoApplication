using System.Web.Routing;
using TodoA.Web.routes;

namespace TodoA.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add("Default", new DefaultRoute());
        }
    }
}
