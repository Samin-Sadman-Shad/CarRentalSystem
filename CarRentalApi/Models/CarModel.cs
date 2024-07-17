using System.ComponentModel.DataAnnotations;

namespace CarRentalApi.Models
{
    public class CarModel
    {
        [Key]
        public int Id { get; set; }

        public string ModelName { get; set; } = null!;

        public string Version { get; set; } = null!;

    }
}
