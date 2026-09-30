namespace Kiki.Models
{
    public class Settings
    {
        public class AppAppearance
        {
            string? MainColor { get; set; }
            string? AccentColor { get; set; }
            string? TextColor { get; set; }
            string? TextSize { get; set; }
            string? LayoutStyle { get; set; }
            string? CornerStyle { get; set; }
        }
        public class BackupLocation
        {
            string? SaveLocation { get; set; }
            bool AutoSaveEnabled { get; set; } =  true;
            bool AutoSaveType { get; set; } = true; // false = Interval, true = Time of day
        }

    }
}