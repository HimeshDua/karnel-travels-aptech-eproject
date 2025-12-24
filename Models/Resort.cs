using System.ComponentModel.DataAnnotations;

namespace karnel_travels_mvc.Models
{
    /// <summary>
    /// Represents a resort facility
    /// Includes accommodation, recreational facilities, and capacity information
    /// </summary>
    public class Resort
    {
        /// <summary>
        /// Primary key for the resort
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the resort (e.g., "Ocean Paradise Resort")
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Location/region where the resort is located
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Location { get; set; } = string.Empty;

        /// <summary>
        /// Description of resort facilities and amenities
        /// </summary>
        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Price per night for standard accommodation
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Quality/category rating (e.g., "Luxury", "Premium", "Standard")
        /// </summary>
        [StringLength(50)]
        public string Quality { get; set; } = string.Empty;

        /// <summary>
        /// Number of rooms/units available
        /// </summary>
        public int Availability { get; set; }

        /// <summary>
        /// Total guest capacity of the resort
        /// </summary>
        public int Capacity { get; set; }
    }
}
