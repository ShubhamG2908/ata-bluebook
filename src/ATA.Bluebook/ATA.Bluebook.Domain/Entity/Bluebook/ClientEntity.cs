using ATA.Domain.Common;

using System.ComponentModel.DataAnnotations;


namespace ATA.Domain.Entity.Bluebook
{
    public class ClientEntity : BaseEntity
    {
        [MaxLength(100)]
        public string ClientCode { get; set; } = default!;

        [MaxLength(100)]
        public string ClientName { get; set; } = default!;

        [MaxLength(100)]
        public string ContactName { get; set; } = default!;

        [MaxLength(100)]
        public string ContactEmail { get; set; } = default!;


        [MaxLength(20)]
        public string ContactPhone { get; set; } = default!;

        [MaxLength(300)]
        public string Address { get; set; } = default!;

        [MaxLength(100)]
        public string City { get; set; } = default!;

        [MaxLength(100)]
        public string State { get; set; } = default!;

        [MaxLength(100)]
        public string Zip { get; set; } = default!;

        public ContactType ContactType { get; set; }

        public ProgramType ProgramType { get; set; }

        public ProjectType ProjectType { get; set; }

        public Status Status { get; set; }

        [MaxLength(100)]
        public string? InternalName { get; set; }

        [MaxLength(100)]
        public string? WMCode { get; set; }
    }
}
