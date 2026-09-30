using Kiki.Models;

namespace Kiki.Models
{
    public class User
    {
        string Username { get; set; } = string.Empty;
        string PasswordHash { get; set; } = string.Empty;
        string? DisplayName { get; set; }
        string? Bio { get; set; }
        string? Pronouns { get; set; }
        string? Boundaries { get; set; }
        string UserKey { get; set; }  = string.Empty;
        public class ProfileAppearance
        {
            string? MainColor { get; set; }
            string? AccentColor { get; set; }
            string? TextColor { get; set; }
            int? AvatarId { get; set; }
            int? BannerId { get; set; }
        }
    }
}