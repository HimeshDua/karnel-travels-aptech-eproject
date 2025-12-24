using System.ComponentModel.DataAnnotations;

namespace karnel_travels_mvc.Models
{
    /// <summary>
    /// Represents a restaurant/dining establishment
    /// Includes cuisine type, pricing, and seating availability
    /// </summary>
    public class Restaurant
    {
        /// <summary>
        /// Primary key for the restaurant
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the restaurant (e.g., "Spice Garden Restaurant")
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Location/area where the restaurant is located
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Location { get; set; } = string.Empty;

        /// <summary>
        /// Description of cuisine type and specialties
        /// </summary>
        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Average price per person
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Quality rating (e.g., "Premium", "Standard", "Budget")
        /// </summary>
        [StringLength(50)]
        public string Quality { get; set; } = string.Empty;

        /// <summary>
        /// Number of tables/seats available
        /// </summary>
        public int Availability { get; set; }
    }
}
