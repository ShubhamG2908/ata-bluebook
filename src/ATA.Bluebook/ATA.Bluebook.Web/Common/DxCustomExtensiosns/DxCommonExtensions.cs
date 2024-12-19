using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Factories;

namespace ATA.Bluebook.Web.Common.DxCustomExtensiosns
{
    public static class DxCommonExtensions
    {
        public static ButtonBuilder AddCustomButton<TModel>(this WidgetFactory<TModel> factory, string buttonText = "Click", ButtonType buttonType = ButtonType.Default, string? clickHandler = null, string? icon = null, bool rtlEnable = false)
        {
            return factory
                .Button().RtlEnabled(rtlEnable)
                .Text(buttonText)
                .Type(buttonType)
                .OnClick(clickHandler)
                .Icon(icon);
        }
    }
}
