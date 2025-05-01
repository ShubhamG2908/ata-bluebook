using ATA.Application.Interface;
using ATA.Application.Models.Bluebook;
using ATA.Domain.Entity.Bluebook;

using MediatR;

using System.Threading;
using System.Threading.Tasks;

namespace ATA.Application.Services.Bluebook.Client.Get
{
    public class GetClientHandler : IRequestHandler<GetClientQuery, ClientModel?>
    {
        private readonly IGenericRepositoryBuilder<ClientEntity> _repo;

        public GetClientHandler(IGenericRepositoryBuilder<ClientEntity> repo)
        {
            _repo = repo;
        }

        public async Task<ClientModel?> Handle(GetClientQuery request, CancellationToken cancellationToken)
        {
            return await _repo.WithFilter(x => x.Id == request.Id && !x.IsRemoved)
                              .WithNoTracking()
                              .WithProjection(c => new ClientModel
                              {
                                  Id = c.Id,
                                  ClientCode = c.ClientCode,
                                  ClientName = c.ClientName,
                                  ContactName = c.ContactName,
                                  ContactEmail = c.ContactEmail,
                                  ContactPhone = c.ContactPhone,
                                  Address = c.Address,
                                  City = c.City,
                                  State = c.State,
                                  Zip = c.Zip,
                                  ContactType = c.ContactType,
                                  ProgramType = c.ProgramType,
                                  ProjectType = c.ProjectType,
                                  Status = c.Status,
                                  InternalName = c.InternalName,
                                  WMCode = c.WMCode,
                                  FinancialEmailList = c.FinancialEmailList,
                                  MarketingEmailList = c.MarketingEmailList
                              })
                              .ExecuteFirstAsync<ClientModel>();
        }
    }
}
