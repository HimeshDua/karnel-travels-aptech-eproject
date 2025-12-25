using System.ComponentModel.DataAnnotations;

namespace karnel_travels_mvc.Models
{
    public class Resort
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
        [Required]
        public decimal Price { get; set; }
        [StringLength(50)]
        public string Quality { get; set; } = string.Empty;
        public int Availability { get; set; }
        public int Capacity { get; set; }
    }
}
