using FluentEmail.Core;
using FluentEmail.Core.Models;

namespace ATA.Application.Models
{
    public class EmailDetailModel
    {

        public required IList<Address> To { get; set; }

        public required string Subject { get; set; }

        /// <summary>
        /// Default From is getting set from the DI. Use this if you want to override.
        /// </summary>
        public Address? From { get; set; }

        public IList<Address>? Cc { get; set; }

        public IList<Address>? Bcc { get; set; }

        public IList<Attachment>? Attachments { get; set; }

        public bool HasAttachment => Attachments != null && Attachments.Any();
        public bool HasBcc => Bcc != null && Bcc.Any();
        public bool HasCc => Cc != null && Cc.Any();
        public bool OverrideFrom => From != null;

        public void AddAttachment(Attachment attachment)
        {
            if (!HasAttachment)
            {
                Attachments = new List<Attachment>();
            }

            Attachments!.Add(attachment);
        }

        public void AddAttachments(IEnumerable<Attachment> attachments) => Attachments.AddRange(attachments);
    }
}
