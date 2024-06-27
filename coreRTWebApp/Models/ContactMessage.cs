using System.ComponentModel.DataAnnotations;

namespace coreRTWebApp.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter the subject")]
        public string? Subject { get; set; }

        [Required(ErrorMessage = "Please enter your message")]
        public string? Message { get; set; }
    }
}
