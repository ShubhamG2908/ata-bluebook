using ATA.Application.Models;

namespace ATA.Application.Interface
{
    public interface IUserContextService
    {
        Task<CurrentUserContextDataModel> GetCurrentUser(Guid TokenId);
    }
}
