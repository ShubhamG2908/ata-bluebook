using DevExtreme.AspNet.Mvc;

namespace ATA.Bluebook.Web.Models
{
    public class ConfirmPopupModel
    {
        public string IconName { get; set; } = string.Empty;
        public string IconClass { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public string CancelButtonText { get; set; } = "Cancel";
        public ButtonType CancelButtonType { get; set; } = ButtonType.Normal;
        public string CancelButtonClickCallback { get; set; } = "() => {}";
        public string OkButtonText { get; set; } = "Ok";
        public ButtonType OkButtonType { get; set; } = ButtonType.Success;
        public string OkButtonClickCallback { get; set; } = "() => {}";

        public ConfirmPopupModel DeletePopupConfig(string okBtnCallBack, string cancelBtnCallBack)
        {
            IconName = "clear";
            IconClass = "custom-delete-icon";
            Title = "Are you sure ?";
            Text = "Do you really want to delete this record? This process cannot be undone.";
            CancelButtonText = "Cancel";
            CancelButtonType = ButtonType.Normal;
            CancelButtonClickCallback = cancelBtnCallBack;
            OkButtonText = "Delete";
            OkButtonType = ButtonType.Danger;
            OkButtonClickCallback = okBtnCallBack;
            return this;
        }
    }
}
