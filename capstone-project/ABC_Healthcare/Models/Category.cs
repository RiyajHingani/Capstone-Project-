using System.ComponentModel.DataAnnotations;

namespace HealthCare.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, MinLength(2, ErrorMessage = "Minimum length is 2")]
        [RegularExpression(@"^[a-zA-Z-]+$", ErrorMessage = "Only letters are allowed")]
        public string Name { get; set; }

        [Required]
        public string Slug { get; set; }
        public int Sorting { get; set; }
    }
}
