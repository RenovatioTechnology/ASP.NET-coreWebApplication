using System.ComponentModel.DataAnnotations;

namespace coreRTWebApp.Models
{
    public class AboutUs
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Title { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
