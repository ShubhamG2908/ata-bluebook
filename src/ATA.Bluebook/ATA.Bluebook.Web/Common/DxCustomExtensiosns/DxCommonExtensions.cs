using ATA.Bluebook.Web.Common.DxCustomExtensiosns.Configs;
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

        public static TabsBuilder AddCustomTabs<TModel>(this WidgetFactory<TModel> factory, TabsConfig config)
        {
            var tabs = factory.Tabs().Width(config.Width)
                                    .ID(config.ControlId)
                                    .DataSource(new JS(config.JSDataSourceName))
                                    .SelectedItem(new JS(config.JSSelectedItem)) ;

            if (!string.IsNullOrEmpty(config.InitializeCallBack))
            {
                tabs.OnInitialized(config.InitializeCallBack);
            }
            if (!string.IsNullOrEmpty(config.SelectionChangedCallBack))
            {
                tabs.OnSelectionChanged(config.SelectionChangedCallBack);
            }
            return tabs;
        }

        public static MultiViewBuilder AddCustomMultiView<TModel>(this WidgetFactory<TModel> factory, MultiViewConfig config)
        {
            var multiview = factory.MultiView()
                                    .ID(config.ControlId)
                                    .DataSource(new JS(config.JSDataSourceName))
                                    .SelectedItem(new JS(config.JSSelectedItem))
                                    .Loop(config.Loop).SwipeEnabled(config.SwipeEnabled)
                                    .AnimationEnabled(config.AnimationEnabled)
                                    .ItemTemplate(new TemplateName(config.ItemTemplate));

            if (!string.IsNullOrEmpty(config.InitializeCallBack))
            {
                multiview.OnInitialized(config.InitializeCallBack);
            }
            if (!string.IsNullOrEmpty(config.SelectionChangedCallBack))
            {
                multiview.OnSelectionChanged(config.SelectionChangedCallBack);
            }

            return multiview;
        }

    }
}
