using System.ComponentModel.DataAnnotations;

namespace karnel_travels_mvc.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;
        [Required]
        [StringLength(1000)]
        public string Message { get; set; } = string.Empty;
        [Required]
        public DateTime SubmittedDate { get; set; }
    }
}
