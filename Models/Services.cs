using System.ComponentModel.DataAnnotations;

namespace BluelineWebsite.Models
{
    public class Service
    {
        public int Id { get; set; }

        // English Content
        [Required, MaxLength(150)]
        public string TitleEn { get; set; } = string.Empty;

        [Required, MaxLength(300)]
        public string ShortDescriptionEn { get; set; } = string.Empty;

        [Required]
        public string FullDescriptionEn { get; set; } = string.Empty;

        // Arabic Content
        [Required, MaxLength(150)]
        public string TitleAr { get; set; } = string.Empty;

        [Required, MaxLength(300)]
        public string ShortDescriptionAr { get; set; } = string.Empty;

        [Required]
        public string FullDescriptionAr { get; set; } = string.Empty;

        // Core Metadata
        [Required, MaxLength(150)]
        public string Slug { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? IconCssClass { get; set; } = "fa-anchor";

        public bool IsFeatured { get; set; } = false;
        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}