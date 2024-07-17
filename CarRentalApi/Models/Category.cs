using System.ComponentModel.DataAnnotations;

namespace CarRentalApi.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public CategoryNames  CategoryNames { get; set; }

        List<Car?> Cars { get; set; } = new List<Car?>();
    }
}
