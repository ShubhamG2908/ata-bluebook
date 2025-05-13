using ATA.Application.Models.Bluebook;

using MediatR;

namespace ATA.Application.Services.Bluebook.Client.Get
{
    public record GetClientQuery(Guid Id) : IRequest<ClientModel?>;
}
