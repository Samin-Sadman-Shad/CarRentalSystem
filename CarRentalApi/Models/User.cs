using System.ComponentModel.DataAnnotations;

namespace CarRentalApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;

    }
}
