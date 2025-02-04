using ATA.Shared.Application.Models;

namespace ATA.Shared.Application.Interface
{
    public interface IEmailService
    {
        Task Send<T>(IList<EmailDetailModel> emailMetadata, T emailModel, string templateFile);
        Task Send<T>(EmailDetailModel emailMetadata, T emailModel, string templateFile);
    }
}
