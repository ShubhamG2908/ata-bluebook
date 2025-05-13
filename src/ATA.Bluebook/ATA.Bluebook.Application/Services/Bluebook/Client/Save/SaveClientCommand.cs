using ATA.Application.Models.Bluebook;
using MediatR;

namespace ATA.Application.Services.Bluebook.Client.Save
{
    public class SaveClientCommand : IRequest<SaveResponse>
    {
        public ClientModel Client { get; }

        public SaveClientCommand(ClientModel client)
        {
            Client = client;
        }
    }
}
