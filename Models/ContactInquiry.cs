using System.ComponentModel.DataAnnotations;

namespace BluelineWebsite.Models
{
    public class ContactInquiry
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [MaxLength(25)]
        public string? Phone { get; set; }

        [Required, MaxLength(200)]
        public string Subject { get; set; } = string.Empty;

        [Required, MaxLength(2000)]
        public string Message { get; set; } = string.Empty;

        public bool IsRead { get; set; } = false;
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
        public bool IsProcessed { get; set; } = false;
    }
}