using System.ComponentModel.DataAnnotations;

namespace BluelineWebsite.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required, MaxLength(150)]
        public string ClientName { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Location { get; set; } = string.Empty;

        [Required, MaxLength(500)]
        public string Summary { get; set; } = string.Empty;

        public string DetailedCaseStudy { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }
        public DateTime CompletionDate { get; set; }

        // Relationship: Optional link to a specific Marine Service
        public int? ServiceId { get; set; }
        public Service? Service { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
