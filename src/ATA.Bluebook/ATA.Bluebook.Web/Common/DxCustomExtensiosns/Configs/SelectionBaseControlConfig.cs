using DevExtreme.AspNet.Mvc;

namespace ATA.Bluebook.Web.Common.DxCustomExtensiosns.Configs
{
    /// <summary>
    /// Base class for all selection controls like Selectbox, Tagbox, Dropdownbox etc.
    /// </summary>
    public class SelectionBaseControlConfig : BaseControlConfig
    {
        /// <summary>
        /// Controller Name which contains method that is used to get data to show in the list.
        /// </summary>
        public required string DbSourceController { get; set; } = string.Empty;
        /// <summary>
        /// Method (Action) Name that is used to get data to show in the list.
        /// </summary>
        public required string DBSourceAction { get; set; } = string.Empty;
        /// <summary>
        /// Key field of the object that is used for binding the data.
        /// </summary>
        public string KeyField { get; set; } = string.Empty;
        /// <summary>
        /// field name which is used to show data into the selection box.
        /// </summary>
        public string DisplayField { get; set; } = string.Empty;
        /// <summary>
        /// DevExpress load mode configuration
        /// </summary>
        public DataSourceLoadMode LoadMode { get; set; } = DataSourceLoadMode.Raw;
        /// <summary>
        /// Pass value change call back method.
        /// </summary>
        public string ValueChangeCallBack { get; set; } = string.Empty;
    }
}
