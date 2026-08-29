namespace BluelineWebsite.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Service> FeaturedServices { get; set; } = new List<Service>();
        public IEnumerable<Project> FeaturedProjects { get; set; } = new List<Project>();
        public bool IsArabic { get; set; }
    }
}