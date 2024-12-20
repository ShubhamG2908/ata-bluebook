namespace ATA.Bluebook.Web.Models
{
    public class BreadCrumbModel
    {
        public string ControllerName { get; set; } = string.Empty;
        public string ActionName { get; set; } = string.Empty;
        public string MenuItemText { get; set; } = string.Empty;
        public Dictionary<string, string>? UrlParams { get; set; }
        public bool IsActive { get; set; } = false;

        public BreadCrumbModel() { }

        public BreadCrumbModel(string menuItemText, string controllerName = "", string actionName = "")
        {
            MenuItemText = menuItemText;
            ControllerName = controllerName;
            ActionName = actionName;
        }

        public BreadCrumbModel SetActive()
        {
            IsActive = true;
            return this;
        }
    }
}
