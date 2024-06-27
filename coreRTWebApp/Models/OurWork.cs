using System.ComponentModel.DataAnnotations;

namespace coreRTWebApp.Models
{
    public class OurWork
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        // You can add more properties like categories, tags, etc. as needed
    }
}
