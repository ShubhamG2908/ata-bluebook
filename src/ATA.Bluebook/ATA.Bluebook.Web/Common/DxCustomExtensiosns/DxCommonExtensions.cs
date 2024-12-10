using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Factories;

namespace ATA.Bluebook.Web.Common.DxCustomExtensiosns
{
    public static class DxCommonExtensions
    {
        public static ButtonBuilder AddCustomButton<TModel>(this WidgetFactory<TModel> factory, string buttonText = "Click", ButtonType buttonType = ButtonType.Default, string? clickHandler = null, string? icon = null)
        {
            return factory
                .Button()
                .Text(buttonText)
                .Type(buttonType)
                .OnClick(clickHandler)
                .Icon(icon);
        }
    }
}
