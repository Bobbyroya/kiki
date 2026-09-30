namespace Kiki.Models
{
    public class Message
    {
        string SenderKey { get; set; } = string.Empty;
        string? Contents { get; set; }
        string? MediaKey { get; set; }
        DateTime DateAndTimeSent { get; set; }
    }
}