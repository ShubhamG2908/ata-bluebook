using ATA.Domain.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATA.Application.Services.Bluebook.Client.Get
{
    public class ClientResponse
    {
        public Guid Id { get; set; }
        public string ClientCode { get; set; } = default!;
        public string ClientName { get; set; } = default!;
        public string ContactName { get; set; } = default!;
        public string ContactEmail { get; set; } = default!;
        public string ContactPhone { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string City { get; set; } = default!;
        public string State { get; set; } = default!;
        public string Zip { get; set; } = default!;
        public ContactType ContactType { get; set; }
        public ProgramType ProgramType { get; set; }
        public ProjectType ProjectType { get; set; }
        public Status Status { get; set; }
        public string? InternalName { get; set; }
        public string? WMCode { get; set; }
    }
}
