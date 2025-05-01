using ATA.Application.Models.Bluebook;

using MediatR;

namespace ATA.Application.Services.Bluebook.Client.List
{
    public record ListClientQuery() : IRequest<List<ClientModel>>;
}
