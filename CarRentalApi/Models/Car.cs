using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalApi.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        public int CarModelId { get; set; }
        [ForeignKey(nameof(CarModelId))]
        public CarModel CarModel { get; set; } = null!;

        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;
        public int BrandId { get; set; }
        [ForeignKey(nameof(BrandId))]
        public Brand Brand { get; set; } = null!;

        public int LocationId { get; set; }
        [ForeignKey(nameof(LocationId))]
        public Location? Location { get; set; }

        public List<Review?> Reviews { get; set; } = new List<Review?>();
    }
}
