namespace ATA.Bluebook.Web.Models
{
    public class StepperPageModel
    {
        public string StepperId { get; set; } = default!;
        public List<StepperModel> Steps { get; set; } = [];
    }

    public class StepperModel
    {
        public string Label { get; set; } = default!;
        public string FormName { get; set; } = default!;

    }
}
