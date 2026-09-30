namespace Kiki.Models
{
    public class Media
    {
        public class Image
        {
            DateTime DateAndTimeSent { get; set; }
            string ImageName { get; set; } = string.Empty;
            string ImageKey { get; set; } = string.Empty;
        }
    }
}