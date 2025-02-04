using System;
using System.Linq;

namespace ATA.Domain.Entity
{
    public interface ITenantEntity
    {
        public Guid TenantId { get; set; }
    }
}
