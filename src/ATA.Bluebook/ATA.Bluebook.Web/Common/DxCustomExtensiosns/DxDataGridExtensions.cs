using ATA.Bluebook.Web.Models.DxConfigs;

using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;

using Microsoft.AspNetCore.Mvc.Rendering;

namespace ATA.Bluebook.Web.Common.DxCustomExtensiosns
{
    public static class DxDataGridExtensions
    {
        public static DataGridBuilder<T> AddCustomDxDataGrid<T>(this IHtmlHelper htmlHelper, List<DxDataGridColumnConfig> columnConfigs, DxDataGridConfig gridConfigs)
        {
            DataGridBuilder<T> builder = htmlHelper.DevExtreme()
                                                                             .DataGrid<T>()
                                                                             .DataSource(cfg => cfg.SetupDataSource(gridConfigs))
                                                                             .Columns(cfg => cfg.SetupColumns<T>(columnConfigs))
                                                                             .GroupPanel(cfg => cfg.SetupGroupPanel(gridConfigs.ShowGroupPanel))
                                                                             .FilterRow(cfg => cfg.Visible(true))
                                                                             .ColumnHidingEnabled(gridConfigs.AllowColumnHiding)
                                                                             .Pager(SetupDefaultPager);

            if (gridConfigs.GridEditingConfig.EnableGridEdit)
            {
                builder.Editing(cfg =>
                {
                    cfg.Mode(GridEditMode.Popup);
                    cfg.AllowAdding(IsEditActionEnable(gridConfigs.GridEditingConfig.InsertActionName));
                    cfg.AllowDeleting(IsEditActionEnable(gridConfigs.GridEditingConfig.DeleteActionName));
                    cfg.AllowUpdating(IsEditActionEnable(gridConfigs.GridEditingConfig.UpdateActionName));
                    cfg.UseIcons(true);
                    cfg.Popup(pcfg => pcfg.Title(gridConfigs.GridEditingConfig.PopupTitle));
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

        private static ControllerDataSourceOptionsBuilder SetupDataSource(this DataSourceFactory dataSource, DxDataGridConfig config)
        {
            var builder = dataSource.Mvc().
                Controller(config.DataSourceConfig.ControllerName)
                .LoadAction(config.DataSourceConfig.LoadActionName)
                .Key(config.DataSourceConfig.Key);

            if (IsEditActionEnable(config.GridEditingConfig.UpdateActionName))
                builder.UpdateAction(config.GridEditingConfig.UpdateActionName);

            if (IsEditActionEnable(config.GridEditingConfig.DeleteActionName))
                builder.UpdateAction(config.GridEditingConfig.DeleteActionName);

            if (IsEditActionEnable(config.GridEditingConfig.InsertActionName))
                builder.UpdateAction(config.GridEditingConfig.InsertActionName);

            return builder;
        }

        private static bool IsEditActionEnable(string actionName) => string.IsNullOrWhiteSpace(actionName);
        #endregion
    }
}
