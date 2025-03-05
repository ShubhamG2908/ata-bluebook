using ATA.Application.Interface;
using ATA.Domain.Entity.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ATA.Application.Services.Shared.User.UpdateMigrateUserProfile
{
    public class UpdateMigratedUserProfileHandler : IRequestHandler<UpdateMigratedUserProfileCommand, bool>
    {
        private readonly IGenericRepositoryBuilder<UserSeceurityEntity> _userSeceurityRepo;

        public UpdateMigratedUserProfileHandler(IGenericRepositoryBuilder<UserSeceurityEntity> userSeceurityRepo)
        {
            _userSeceurityRepo = userSeceurityRepo;
        }

        public async Task<bool> Handle(UpdateMigratedUserProfileCommand request, CancellationToken cancellationToken)
        {
            var userData = await _userSeceurityRepo.WithFilter(x => x.Id == request.UserSeceretId).WithInclude(x => x.Include(y => y.User)).ExecuteFirstAsync<UserSeceurityEntity>();

            if (userData == null)
                return false;

            userData.User.Email = request.Email;
            userData.Password = request.Password;
            userData.Username = request.Username;
            userData.User.Fullname = request.Fullname;

            var res = await _userSeceurityRepo.UpSertAsync(userData);

            return res;

        }
    }
}
