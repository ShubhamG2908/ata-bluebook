
using ATA.Application.Interface;
using ATA.Domain.Entity.Shared;

using MediatR;

using Microsoft.EntityFrameworkCore;

namespace ATA.Application.Services.Shared.User.UpdateMigrateUserProfile
{
    public record UpdateMigratedUserProfileCommand(Guid UserSeceretId, Guid UserId, string Email, string Username, string Fullname, string Password) : IRequest<bool>;
}
