using System.ComponentModel.DataAnnotations;

namespace ATA.Domain.Entity.Shared
{
    public class AdressEntity : BaseEntity
    {
        [MaxLength(200)]
        public string Line1 { get; set; } = default!;

        [MaxLength(200)]
        public string Line2 { get; set; } = default!;

        [MaxLength(100)]
        public string City { get; set; } = default!;

        [MaxLength(100)]
        public string State { get; set; } = default!;

        [MaxLength(100)]
        public string Country { get; set; } = default!;

        [MaxLength(10)]
        public string ZipCode { get; set; } = default!;

        public virtual UserMasterEntity User { get; set; } = default!;
    }
}
