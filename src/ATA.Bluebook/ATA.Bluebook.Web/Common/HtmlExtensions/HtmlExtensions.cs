using Microsoft.AspNetCore.Mvc.Rendering;

namespace ATA.Bluebook.Web.Common.HtmlExtensions
{
    public static class HtmlExtensions
    {
        public static string GetActiveRouteClassName(this IHtmlHelper html, params string[] routerName)
        {
            var routeData = html.ViewContext.RouteData;
            var currentController = routeData.Values["controller"]?.ToString();
            var currentAction = routeData.Values["action"]?.ToString();

            if (routerName.Contains(currentController, StringComparer.OrdinalIgnoreCase) ||
                routerName.Contains(currentAction, StringComparer.OrdinalIgnoreCase))
            {
                return "active";
            }
            return string.Empty;
        }
    }
}
