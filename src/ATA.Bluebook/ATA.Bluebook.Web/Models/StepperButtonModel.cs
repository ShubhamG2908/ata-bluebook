namespace ATA.Bluebook.Web.Models
{
    public class StepperButtonModel
    {
        public string PreviousLabel { get; set; } = default!;
        public string NextLabel { get; set; } = default!;
        public string PreviousBtnClickHandler { get; set; } = default!;
        public string NextBtnClickHandler { get; set; } = default!;
        public bool DisplayNextButton { get; set; } = true;
        public bool DisplayPreviousButton { get; set; } = true;
    }
}
