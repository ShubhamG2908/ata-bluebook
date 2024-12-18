namespace ATA.Bluebook.Web.Models.Jobs
{
    public class JobFormPageModel
    {
        public JobDetailsForm JobDetailsForm { get; set; } = default!;

    }

    public class JobDetailsForm
    {
        public string JobId { get; set; } = string.Empty;
        public string JobType { get; set; } = string.Empty;
        public string JobName { get; set; } = string.Empty;
        public DateTime FirstMailDate { get; set; }
        public DateTime EndMailDate { get; set; }
        public string EstimatedQty { get; set; } = string.Empty;
        public string EstIncPerPiece { get; set; } = string.Empty;
        public string EstCostPerPiece { get; set; } = string.Empty;
        public string Issue { get; set; } = string.Empty;
        public string Technique { get; set; } = string.Empty;
        public string Copywriter { get; set; } = string.Empty;
        public string Coordinator { get; set; } = string.Empty;
        public string PackageSize { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string PackageCode { get; set; } = string.Empty;
        public string Agency { get; set; } = string.Empty;
        public string CostComplete { get; set; } = string.Empty;
        public string CostEstimateOk { get; set; } = string.Empty;
        public bool DollarBills { get; set; } = false;
        public bool NoInvoice { get; set; } = false;
        public string FundCode { get; set; } = string.Empty;
        public string JobDetails { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
    }
}
