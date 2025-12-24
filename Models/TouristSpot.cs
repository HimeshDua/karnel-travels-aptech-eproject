using System.ComponentModel.DataAnnotations;

namespace karnel_travels_mvc.Models
{
    /// <summary>
    /// Represents a tourist spot/location within the country
    /// Includes beaches, monuments, historical sites, etc.
    /// </summary>
    public class TouristSpot
    {
        /// <summary>
        /// Primary key for the tourist spot
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the tourist spot (e.g., "Marina Beach", "Taj Mahal")
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Location/city where the tourist spot is located
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Location { get; set; } = string.Empty;

        /// <summary>
        /// Detailed description of the tourist spot
        /// </summary>
        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Quality rating (e.g., "Excellent", "Good", "Average")
        /// </summary>
        [StringLength(50)]
        public string Quality { get; set; } = string.Empty;

        /// <summary>
        /// Indicates if the tourist spot is currently available/open for visitors
        /// </summary>
        public bool IsAvailable { get; set; }
    }
}
