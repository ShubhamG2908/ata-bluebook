using ATA.Application.Interface;
using ATA.Application.Models;

using FluentEmail.Core;

using Microsoft.Extensions.Hosting;


namespace ATA.Infrastructure.Providers.NotificationService
{
    public class EmailService : IEmailService
    {
        private readonly IFluentEmailFactory _fluentEmailFactory;
        private readonly IHostEnvironment _environment;

        public EmailService(IFluentEmailFactory fluentEmailFactory, IHostEnvironment environment)
        {
            _fluentEmailFactory = fluentEmailFactory;
            _environment = environment;
        }

        public async Task Send<T>(IList<EmailDetailModel> emailMetadata, T emailModel, string templateFile)
        {
            foreach (var item in emailMetadata)
            {
                await Send(item, emailModel, templateFile);
            }
        }

        public async Task Send<T>(EmailDetailModel emailMetadata, T emailModel, string templateFile)
        {
            if (!string.IsNullOrWhiteSpace(templateFile))
            {
                templateFile = Path.Combine(_environment.ContentRootPath, "wwwroot", "EmailTemplates", templateFile);
            }

            var emailObj = _fluentEmailFactory
                            .Create()
                            .To(emailMetadata.To)
                            .Subject(emailMetadata.Subject)
                            .UsingTemplateFromFile(templateFile, emailModel);

            if (emailMetadata.OverrideFrom)
                emailObj.SetFrom(emailMetadata.From!.EmailAddress, emailMetadata.From.Name);

            if (emailMetadata.HasCc)
                emailObj.CC(emailMetadata.Cc);

            if (emailMetadata.HasBcc)
                emailObj.BCC(emailMetadata.Bcc);

            if (emailMetadata.HasAttachment)
                emailObj.Attach(emailMetadata.Attachments);

            await emailObj.SendAsync();
        }
    }
}
