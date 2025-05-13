using ATA.Application.Interface;
using ATA.Domain.Entity.Bluebook;
using ATA.Application.Models.Bluebook;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ATA.Application.Services.Bluebook.Client.Save
{
    public class SaveClientHandler : IRequestHandler<SaveClientCommand, SaveResponse>
    {
        private readonly IGenericRepositoryBuilder<ClientEntity> _repo;

        public SaveClientHandler(IGenericRepositoryBuilder<ClientEntity> repo)
        {
            _repo = repo;
        }

        public async Task<SaveResponse> Handle(SaveClientCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // Map ClientModel to ClientEntity
                var clientEntity = new ClientEntity
                {
                    Id = request.Client.Id,
                    ClientCode = request.Client.ClientCode,
                    ClientName = request.Client.ClientName,
                    ContactName = request.Client.ContactName,
                    ContactEmail = request.Client.ContactEmail,
                    ContactPhone = request.Client.ContactPhone,
                    Address = request.Client.Address,
                    City = request.Client.City,
                    State = request.Client.State,
                    Zip = request.Client.Zip,
                    ContractType = request.Client.ContractType,
                    ProgramType = request.Client.ProgramType,
                    ProjectType = request.Client.ProjectType,
                    Status = request.Client.Status,
                    InternalName = request.Client.InternalName,
                    WMCode = request.Client.WMCode,
                    FinancialEmailList = request.Client.FinancialEmailList,
                    MarketingEmailList = request.Client.MarketingEmailList
                };

                // Save (Upsert) client entity to the database
                var success = await _repo.UpSertAsync(clientEntity);

                if (success)
                {
                    return new SaveResponse { Success = true };
                }

                return new SaveResponse { Success = false, ErrorMessage = "Failed to save client." };
            }
            catch (Exception ex)
            {
                // Log exception if necessary
                return new SaveResponse { Success = false, ErrorMessage = ex.Message };
            }
        }
    }
}
