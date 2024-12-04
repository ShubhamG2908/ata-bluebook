using Microsoft.AspNetCore.Mvc.Rendering;

namespace ATA.Bluebook.Web.Common.HtmlExtensions
{
    public static class HtmlExtensions
    {
        public static string IsActive(this IHtmlHelper html, params string[] controllers)
        {
            var routeData = html.ViewContext.RouteData;
            var currentController = routeData.Values["controller"]?.ToString();

            if (controllers.Contains(currentController, StringComparer.OrdinalIgnoreCase))
            {
                return "active";
            }
            return string.Empty;
        }

    }
}
