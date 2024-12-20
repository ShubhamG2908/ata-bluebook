namespace ATA.Bluebook.Web.Common.DxCustomExtensiosns.Configs
{
    public class PopupConfig
    {
        public string ControlId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public bool ShowTitle { get; set; } = false;
        public string MaxHeight { get; set; } = "300px";
        public string MaxWidth { get; set; } = "350px";
        public bool ShowCloseButton { get; set; } = true;
        public string TemplateName { get; set; } = string.Empty;

        public PopupConfig DeletePopupConfig(string controlId, string templateName)
        {
            MaxHeight = "300px";
            MaxWidth = "350px";
            ShowTitle = false;
            ControlId = controlId;
            TemplateName = templateName;
            return this;
        }
    }
}
