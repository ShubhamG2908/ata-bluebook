using ATA.Bluebook.Web.Models.DxConfigs;

using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;

using Microsoft.AspNetCore.Mvc.Rendering;

namespace ATA.Bluebook.Web.Common.DxDataGridExtensions
{
    public static class DxDataGridExtensions
    {
        public static DataGridBuilder<T> AddCustomDxDataGrid<T>(this IHtmlHelper htmlHelper, List<DxDataGridColumnConfig> columnConfigs, DxDataGridConfig<T> gridConfigs)
        {
            DataGridBuilder<T> builder = htmlHelper.DevExtreme()
                                                                             .DataGrid<T>()
                                                                             .DataSource(cfg => cfg.SetupDataSource(gridConfigs))
                                                                             .Columns(cfg => cfg.SetupColumns<T>(columnConfigs))
                                                                             .GroupPanel(cfg => cfg.SetupGroupPanel(gridConfigs.ShowGroupPanel))
                                                                             .FilterRow(cfg => cfg.Visible(true))
                                                                             .ColumnHidingEnabled(gridConfigs.AllowColumnHiding)
                                                                             .Pager(SetupDefaultPager)
                                                                             .StateStoring(SetupStateStoringMethod);

            if (gridConfigs.GridEditingConfig.EnableGridEdit)
            {
                builder.Editing(cfg =>
                {
                    cfg.Mode(GridEditMode.Popup);
                    cfg.AllowAdding(gridConfigs.GridEditingConfig.AllowCreateOperation);
                    cfg.AllowDeleting(gridConfigs.GridEditingConfig.AllowDeleteOperation);
                    cfg.AllowUpdating(gridConfigs.GridEditingConfig.AllowUpdateOperation);
                    cfg.UseIcons(true);
                    cfg.Popup(pcfg =>
                    {
                        pcfg.Title(gridConfigs.GridEditingConfig.PopupTitle)
                                                           .ShowTitle(true)
                                                           .EnableBodyScroll(true)
                                                           .ShowCloseButton(true)
                                                           .DragEnabled(true)
                                                           .ContentTemplate(new TemplateName(gridConfigs.GridEditingConfig.ContentTemplateName));

                        if (gridConfigs.GridEditingConfig.PopupWidth.HasValue)
                        {
                            pcfg.Width(gridConfigs.GridEditingConfig.PopupWidth.Value);
                        }
                        if (gridConfigs.GridEditingConfig.PopupHeight.HasValue)
                        {
                            pcfg.Height(gridConfigs.GridEditingConfig.PopupHeight.Value);
                        }
                    });

                    //if (gridConfigs.GridEditingConfig.FormBuilder != null)
                    //{
                    //    cfg.Form(gridConfigs.GridEditingConfig.FormBuilder);
                    //}
                });
            }
            return builder;
        }

        #region PRIVATE DATA GRID CONFIG HELPERS
        private static Action<DataGridPagerBuilder> SetupDefaultPager = (builder) =>
        {
            builder.Visible(true);
            builder.DisplayMode(GridPagerDisplayMode.Compact);
            builder.ShowPageSizeSelector(true);
            builder.AllowedPageSizes(new JS("[10, 25, 50, 100]"));
            builder.ShowInfo(true);
            builder.ShowNavigationButtons(true);
        };

        private static void SetupColumns<T>(this CollectionFactory<DataGridColumnBuilder<T>> builder, List<DxDataGridColumnConfig> columnConfigs)
        {
            columnConfigs.ForEach(column => builder.Add()
                                                                               .DataType(column.DataType)
                                                                               .DataField(column.Field)
                                                                               .Format(column.Format)
                                                                               .Caption(column.Caption));
        }

        private static void SetupGroupPanel(this DataGridGroupPanelBuilder builder, bool showGroupPanel)
        {
            builder.Visible(showGroupPanel);
            builder.EmptyPanelText("Drag a column here for grouping");
        }

        private static ControllerDataSourceOptionsBuilder SetupDataSource<T>(this DataSourceFactory dataSource, DxDataGridConfig<T> config)
        {
            var builder = dataSource.Mvc().
                Controller(config.DataSourceConfig.ControllerName)
                .LoadAction(config.DataSourceConfig.LoadActionName)
                .Key(config.DataSourceConfig.Key);

            if (config.GridEditingConfig.AllowUpdateOperation)
                builder.UpdateAction(config.GridEditingConfig.UpdateActionName);

            if (config.GridEditingConfig.AllowDeleteOperation)
                builder.UpdateAction(config.GridEditingConfig.DeleteActionName);

            if (config.GridEditingConfig.AllowCreateOperation)
                builder.UpdateAction(config.GridEditingConfig.InsertActionName);

            return builder;
        }

        private static Action<DataGridStateStoringBuilder> SetupStateStoringMethod = (builder) => builder.Enabled(true)
                                                                                                                                                                    .Type(StateStoringType.Custom)
                                                                                                                                                                    .StorageKey($"dx_{Guid.NewGuid}");
        #endregion
    }
}
