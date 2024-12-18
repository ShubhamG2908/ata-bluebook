using ATA.Bluebook.Web.Common.Constants;
using System.ComponentModel.DataAnnotations;

namespace ATA.Bluebook.Web.Models.Jobs
{
    public class JobFormPageModel
    {
        public JobDetailsForm JobDetailsForm { get; set; } = default!;

    }

    public class JobDetailsForm
    {
        [Required]
        [Display(Name = "Job Id")]
        public string JobId { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Job Type")]
        public string JobType { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Job Name")]
        public string JobName { get; set; } = string.Empty;
        [Required]
        [Display(Name = "First Mail Date")]
        public DateTime FirstMailDate { get; set; }
        [Required]
        [Display(Name = "End Mail Date")]
        public DateTime EndMailDate { get; set; }
        [Required]
        [Display(Name = "Estimated Quantity")]
        [RegularExpression(RegexConstants.PositiveNumber, ErrorMessage = "Invalid input. Only numbers are allowed.")]
        public int EstimatedQty { get; set; }
        [Required]
        [Display(Name = "Est Inc/Piece")]
        [RegularExpression(RegexConstants.FloatingPositiveNumber, ErrorMessage = "Invalid input. Only numbers are allowed.")]
        public decimal EstIncPerPiece { get; set; }
        [Required]
        [Display(Name = "Est Cost/Piece")]
        [RegularExpression(RegexConstants.FloatingPositiveNumber, ErrorMessage = "Invalid input. Only numbers are allowed.")]
        public decimal EstCostPerPiece { get; set; }
        public string Issue { get; set; } = string.Empty;
        public string Technique { get; set; } = string.Empty;
        public string Copywriter { get; set; } = string.Empty;
        public string Coordinator { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Package Size")]
        public string PackageSize { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Package Code")]
        public string PackageCode { get; set; } = string.Empty;
        public string Agency { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Cost Complete")]
        public string CostComplete { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Cost Estimate Ok")]
        public string CostEstimateOk { get; set; } = string.Empty;
        public bool DollarBills { get; set; } = false;
        public bool NoInvoice { get; set; } = false;
        [Required]
        [Display(Name = "Fund Code")]
        public string FundCode { get; set; } = string.Empty;
        public string? JobDetails { get; set; }
        public string? Instructions { get; set; }
    }
}
