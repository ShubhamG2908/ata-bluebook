using ATA.Application.Interface;
using ATA.Application.Models.Bluebook;
using ATA.Domain.Entity.Bluebook;

using MediatR;

namespace ATA.Application.Services.Bluebook.Client.List
{
    public class GetAllClientsHandler : IRequestHandler<GetAllClientsQuery, List<ClientModel>>
    {
        private readonly IGenericRepositoryBuilder<ClientEntity> _repo;

        public GetAllClientsHandler(IGenericRepositoryBuilder<ClientEntity> repo)
        {
            _repo = repo;
        }

        public async Task<List<ClientModel>> Handle(GetAllClientsQuery request, CancellationToken cancellationToken)
        {
            return await _repo.WithFilter(x => x.IsRemoved == false).WithNoTracking()
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
                                  WMCode = c.WMCode
                              })
                              .ExecuteListAsync<ClientModel>();
        }
    }
}
