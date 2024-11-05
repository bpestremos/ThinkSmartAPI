using Microsoft.EntityFrameworkCore;

namespace ThinkSmartAPI.Models
{
    [Keyless]
    public class Users
    {
        public int UserID { get; set; }
        public Guid UserCode { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Role { get; set; } // Consider using an enum if roles have predefined values
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastLogin { get; set; }
        public string? Status { get; set; } // Consider using an enum if status has predefined values
        public string? PasswordResetToken { get; set; }
        public DateTime? TokenExpiry { get; set; }
    }
}
