using System.ComponentModel.DataAnnotations;

namespace karnel_travels_mvc.Models
{
    public class TouristSpot
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(100)]
        public string Location { get; set; } = string.Empty;
        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
        [StringLength(50)]
        public string Quality { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
    }
}
