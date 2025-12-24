using System.ComponentModel.DataAnnotations;

namespace karnel_travels_mvc.Models
{
    /// <summary>
    /// Represents transportation/travel information
    /// Includes buses, trains, flights, and other transport options within the country
    /// </summary>
    public class TravelInfo
    {
        /// <summary>
        /// Primary key for the travel information
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Type of transportation (e.g., "Bus", "Train", "Flight", "Ferry")
        /// </summary>
        [Required]
        [StringLength(50)]
        public string TransportType { get; set; } = string.Empty;

        /// <summary>
        /// Route description (e.g., "Mumbai to Goa", "Delhi - Jaipur Express")
        /// </summary>
        [Required]
        [StringLength(200)]
        public string Route { get; set; } = string.Empty;

        /// <summary>
        /// Detailed description of the service, timings, and facilities
        /// </summary>
        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Price/fare for the journey
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Indicates if this service is currently operational
        /// </summary>
        public bool Availability { get; set; }
    }
}
