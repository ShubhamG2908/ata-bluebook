using ATA.Application.Interface;
using ATA.Application.Models;
using ATA.Domain.Entity.Shared;
using Microsoft.EntityFrameworkCore;

namespace ATA.Application.Services
{
    public class UserContextService : IUserContextService
    {
        private readonly IGenericRepositoryBuilder<UserSeceurityEntity> _userSecurityRepository;

        public UserContextService(IGenericRepositoryBuilder<UserSeceurityEntity> userSecurityRepository)
        {
            _userSecurityRepository = userSecurityRepository;
        }

        public async Task<CurrentUserContextDataModel> GetCurrentUser(Guid TokenId)
        {
            if (TokenId == Guid.Empty)
                throw new ArgumentNullException(nameof(TokenId));

            var userInfo = await _userSecurityRepository
                                              .WithFilter(x => x.Id == TokenId)
                                              .WithInclude(source => source.Include(x => x.User)
                                                                                                    .ThenInclude(x => x.UserPermission)
                                                                                              .Include(x => x.User)
                                                                                                    .ThenInclude(x => x.Role))
                                              .WithProjection(x => new CurrentUserContextDataModel
                                              {
                                                  UserId = x.UserId,
                                                  TenantId = x.User.TenantId,
                                                  Role = x.User.Role.Name,
                                                  Email = x.Username,
                                                  Permission = x.User.UserPermission.Permission
                                              })
                                             .ExecuteFirstAsync<CurrentUserContextDataModel>();

            if (userInfo == null)
                throw new UnauthorizedAccessException("User not found");

            return userInfo;
        }
    }
}
