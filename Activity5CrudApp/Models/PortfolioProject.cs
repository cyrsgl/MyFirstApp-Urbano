using System.ComponentModel.DataAnnotations;

namespace Activity4FrontendApp.Models
{
    public class PortfolioProject
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public string Technology { get; set; } = string.Empty;

        public string ProjectLink { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}