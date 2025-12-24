using System.ComponentModel.DataAnnotations;

namespace karnel_travels_mvc.Models
{
    /// <summary>
    /// Represents user feedback and contact form submissions
    /// Stores messages from visitors to the website
    /// </summary>
    public class Feedback
    {
        /// <summary>
        /// Primary key for the feedback entry
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the person submitting feedback
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Email address for contact
        /// </summary>
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Feedback message or inquiry
        /// </summary>
        [Required]
        [StringLength(1000)]
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Date and time when the feedback was submitted
        /// </summary>
        [Required]
        public DateTime SubmittedDate { get; set; }
    }
}
