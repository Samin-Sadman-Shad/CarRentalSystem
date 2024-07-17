using System.ComponentModel.DataAnnotations;

namespace CarRentalApi.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public BrandNames BrandNames { get; set; } 
        
        List<Car?> Cars { get; set; } = new List<Car?>();

    }
}
