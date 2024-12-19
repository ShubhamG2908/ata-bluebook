using DevExtreme.AspNet.Mvc;

namespace ATA.Bluebook.Web.Common.DxCustomExtensiosns.Configs
{
    public class TabsConfig : BaseControlConfig
    {
        public string ControlId { get; set; } = string.Empty;
        public string InitializeCallBack { get; set; } = string.Empty;
        public string SelectionChangedCallBack { get; set; } = string.Empty;
        public string? JSDataSourceName { get; set; }
        public string? JSSelectedItem { get; set; }
        public string Width { get; set; } = "auto";
    }
}
