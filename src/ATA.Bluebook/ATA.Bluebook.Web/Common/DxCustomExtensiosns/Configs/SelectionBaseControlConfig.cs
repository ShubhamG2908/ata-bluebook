using DevExtreme.AspNet.Mvc;

namespace ATA.Bluebook.Web.Common.DxCustomExtensiosns.Configs
{
    public abstract class SelectionBaseControlConfig : BaseControlConfig
    {
        public string DbSourceController { get; set; } = string.Empty;
        public string DBSourceAction { get; set; } = string.Empty;
        public string KeyField { get; set; } = string.Empty;
        public string DisplayField { get; set; } = string.Empty;
        public DataSourceLoadMode LoadMode { get; set; } = DataSourceLoadMode.Raw;
        public string ValueChangeCallBack { get; set; } = string.Empty;
    }
}
