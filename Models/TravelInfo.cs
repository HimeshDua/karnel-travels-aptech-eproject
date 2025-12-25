using System.ComponentModel.DataAnnotations;

namespace karnel_travels_mvc.Models
{
    public class TravelInfo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string TransportType { get; set; } = string.Empty;
        [Required]
        [StringLength(200)]
        public string Route { get; set; } = string.Empty;
        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        public bool Availability { get; set; }
    }
}
