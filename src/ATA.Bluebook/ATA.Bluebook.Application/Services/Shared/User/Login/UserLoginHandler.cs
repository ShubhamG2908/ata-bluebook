using ATA.Application.Interface;
using ATA.Domain.Entity.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
namespace ATA.Application.Services.Shared.User.Login
{

    public class UserLoginHandler : IRequestHandler<UserLoginCommand, UserLoginResponse?>
    {
        private readonly IGenericRepositoryBuilder<UserSeceurityEntity> _repo;

        public UserLoginHandler(IGenericRepositoryBuilder<UserSeceurityEntity> repo)
        {
            _repo = repo;
        }

        public async Task<UserLoginResponse?> Handle(UserLoginCommand request, CancellationToken cancellationToken)
        {
            return await _repo.WithFilter(x => x.Username == request.Username && x.Password == request.Password)
                                                .WithInclude(source => source.Include(x => x.User)
                                                .ThenInclude(x => x.UserPermission)
                                                     .Include(x => x.User)
                                                .ThenInclude(x => x.Role))
                                               .WithProjection(x => new UserLoginResponse
                                               {
                                                   UserId = x.UserId,
                                                   TenantId = x.User.TenantId,
                                                   Role = x.User.Role.Name,
                                                   Username = x.Username,
                                                   Permission = x.User.UserPermission.Permission,
                                                   CookieTokenId = x.Id,
                                                   Email = x.User.Email,
                                                   IsInvitationAccepted = x.IsInvitationAccepted,
                                                   IsMigratedUser = x.User.IsMigratedUser
                                               })
                                              .ExecuteFirstAsync<UserLoginResponse>();
        }
    }
}
