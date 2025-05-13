using ATA.Domain.Common;

using System.ComponentModel.DataAnnotations;

namespace ATA.Application.Models.Bluebook
{
    public class ClientModel
    {
        public Guid Id { get; set; }
        [Required]
        public string ClientCode { get; set; } = default!;
        [Required]
        public string ClientName { get; set; } = default!;
        [Required]
        public string ContactName { get; set; } = default!;
        [Required]
        public string ContactEmail { get; set; } = default!;
        [Required]
        public string ContactPhone { get; set; } = default!;
        [Required]
        public string Address { get; set; } = default!;
        [Required]
        public string City { get; set; } = default!;
        [Required]
        public string State { get; set; } = default!;
        [Required]
        public string Zip { get; set; } = default!;
        public ContractType ContractType { get; set; }
        public ProgramType ProgramType { get; set; }
        public ProjectType ProjectType { get; set; }
        public Status Status { get; set; }
        public string? InternalName { get; set; }
        public string? WMCode { get; set; }
        public string? FinancialEmailList { get; set; }
        public string? MarketingEmailList { get; set; }
    }
}
