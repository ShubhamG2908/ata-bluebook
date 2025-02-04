using MediatR;
namespace ATA.Application.Services.Shared.User.Login
{
    public record UserLoginCommand(string Username, string Password) : IRequest<UserLoginResponse?>;
}
