using ATA.Bluebook.Web.Common.Constants;
using System.ComponentModel.DataAnnotations;

namespace ATA.Bluebook.Web.Models.Jobs
{
    public class JobModel
    {
        public int Id { get; set; }
        public string JobId { get; set; } = string.Empty;
        public string JobType { get; set; } = string.Empty;
        public string JobName { get; set; } = string.Empty;
        public DateTime FirstMailDate { get; set; }
        public DateTime EndMailDate { get; set; }
        public int EstimatedQty { get; set; }
        public decimal EstIncPerPiece { get; set; }
        public decimal EstCostPerPiece { get; set; }
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
        public string? JobDetails { get; set; }
        public string? Instructions { get; set; }

        public JobModel(
            int id,
        string jobId,
        string jobType,
        string jobName,
        DateTime firstMailDate,
        DateTime endMailDate,
        int estimatedQty,
        decimal estIncPerPiece,
        decimal estCostPerPiece,
        string issue,
        string technique,
        string copywriter,
        string coordinator,
        string packageSize,
        string status,
        string packageCode,
        string agency,
        string costComplete,
        string costEstimateOk,
        bool dollarBills,
        bool noInvoice,
        string fundCode,
        string? jobDetails = null,
        string? instructions = null
    )
        {
            Id = id;
            JobId = jobId;
            JobType = jobType;
            JobName = jobName;
            FirstMailDate = firstMailDate;
            EndMailDate = endMailDate;
            EstimatedQty = estimatedQty;
            EstIncPerPiece = estIncPerPiece;
            EstCostPerPiece = estCostPerPiece;
            Issue = issue;
            Technique = technique;
            Copywriter = copywriter;
            Coordinator = coordinator;
            PackageSize = packageSize;
            Status = status;
            PackageCode = packageCode;
            Agency = agency;
            CostComplete = costComplete;
            CostEstimateOk = costEstimateOk;
            DollarBills = dollarBills;
            NoInvoice = noInvoice;
            FundCode = fundCode;
            JobDetails = jobDetails;
            Instructions = instructions;
        }
    }

    public class JobDetailModel
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public string MailCode { get; set; } = string.Empty;
        public string ListName { get; set; } = string.Empty;
        public DateTime MailDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public decimal  Mailed { get; set; }
        public decimal Income {get; set; }
        public decimal Cost { get; set; }

        public JobDetailModel(int id, int jobId, string mailCode, string listName, DateTime mailDate, DateTime lastUpdate, decimal mailed, decimal income, decimal cost)
        {
            Id = id;
            JobId = jobId;
            MailCode = mailCode;
            ListName = listName;
            MailDate = mailDate;
            LastUpdate = lastUpdate;
            Mailed = mailed;
            Income = income;
            Cost = cost;
        }
    }

}
