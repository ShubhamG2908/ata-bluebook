namespace ATA.Application.Models
{
    public class SmtpSettings
    {
        public string From { get; set; } = default!;
        public string Host { get; set; } = default!;
        public int Port { get; set; }
        public bool EnableSSL { get; set; }
        public string DeliveryMethod { get; set; } = default!;
        public string DisplayName { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
