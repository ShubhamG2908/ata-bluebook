using DevExtreme.AspNet.Mvc;

namespace ATA.Bluebook.Web.Models.DxConfigs
{
    public class DxDataGridColumnConfig
    {
        /// <summary>
        /// DataType of the Property.
        /// </summary>
        public required GridColumnDataType DataType { get; set; }

        /// <summary>
        /// Data Property of the Model.
        /// </summary>
        public required string Field { get; set; }

        private string? _caption;

        /// <summary>
        /// Used for column header. 
        /// If no value is provided, it will display value of "Field".
        /// </summary>
        public string Caption
        {
            get { return _caption ?? Field; }
            set { _caption = value; }
        }

        /// <summary>
        /// Indicate the Format type of the Data Property.
        /// </summary>
        public Format Format { get; set; }

        /// <summary>
        /// Only work if the "ColumnHidingEnabled" is set to true.
        /// Will hide the Column if the value is assigned in the any view.
        /// </summary>
        public int? ColumnHidingPriority { get; set; }
    }

    public class DxDataGridConfig
    {
        public DxDataGridConfig()
        {
            GridEditingConfig = new();
        }
        public required string Id { get; set; }
        public required DxDataGridDataSourceConfig DataSourceConfig { get; set; }
        public int PageSize { get; set; } = 20;
        public bool AllowCoulmnResize { get; set; } = true;
        public bool DisplayRowFilters { get; set; } = true;
        public bool AllowColumnReordering { get; set; } = true;
        public bool AllowColumnHiding { get; set; }
        public bool ShowGroupPanel { get; set; } = false;
        public DxDataGridEditingConfig GridEditingConfig { get; set; }
    }

    public class DxDataGridEditingConfig
    {
        public bool EnableGridEdit { get; set; } = false;
        public string UpdateActionName { get; set; } = default!;
        public string DeleteActionName { get; set; } = default!;
        public string InsertActionName { get; set; } = default!;
        public string PopupTitle { get; set; } = default!;

        public bool AllowUpdateOperation => !string.IsNullOrWhiteSpace(UpdateActionName);
        public bool AllowDeleteOperation => !string.IsNullOrWhiteSpace(DeleteActionName);
        public bool AllowCreateOperation => !string.IsNullOrWhiteSpace(InsertActionName);
    }

    public class DxDataGridDataSourceConfig
    {
        public required string ControllerName { get; set; }
        public required string LoadActionName { get; set; }
        public string Key { get; set; } = "Id";
    }
}
