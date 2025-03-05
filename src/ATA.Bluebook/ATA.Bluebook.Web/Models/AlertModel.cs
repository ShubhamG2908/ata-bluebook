namespace ATA.Web.Models
{
    public class AlertModel
    {
        public string? Message { get; set; } = default!;
        public string Type { get; set; } = default!;

        public bool HasMessage => !string.IsNullOrWhiteSpace(Message);
    }
}
