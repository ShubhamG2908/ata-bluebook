using DevExtreme.AspNet.Mvc;

namespace ATA.Bluebook.Web.Common.DxCustomExtensiosns.Configs
{
    public class MultiViewConfig
    {
        public string ItemTemplate { get; set; } = string.Empty;
        public string ControlId { get; set; } = string.Empty;
        public string InitializeCallBack { get; set; } = string.Empty;
        public string SelectionChangedCallBack { get; set; } = string.Empty;
        public string? JSDataSourceName { get; set; }
        public string? JSSelectedItem { get; set; }
        public bool Loop { get; set; } = false;
        public bool AnimationEnabled { get; set; } = true;
        public bool SwipeEnabled { get; set; } = false;
    }
}
