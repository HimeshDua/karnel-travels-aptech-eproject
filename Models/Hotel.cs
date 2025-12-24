using System.ComponentModel.DataAnnotations;

namespace karnel_travels_mvc.Models
{
    /// <summary>
    /// Represents a hotel/accommodation facility
    /// Includes pricing, quality ratings, and availability information
    /// </summary>
    public class Hotel
    {
        /// <summary>
        /// Primary key for the hotel
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the hotel (e.g., "Grand Plaza Hotel")
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Location/city where the hotel is located
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Location { get; set; } = string.Empty;

        /// <summary>
        /// Description of hotel facilities and amenities
        /// </summary>
        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Price per night in local currency
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Quality/star rating (e.g., "5-Star", "4-Star", "Budget")
        /// </summary>
        [StringLength(50)]
        public string Quality { get; set; } = string.Empty;

        /// <summary>
        /// Number of rooms available
        /// </summary>
        public int Availability { get; set; }
    }
}
