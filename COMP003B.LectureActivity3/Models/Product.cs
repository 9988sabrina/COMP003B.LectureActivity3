using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureActivity3.Models
{
    public class Product
    {
        [Required]
        public string Name { get; set; }

        [Range(0.01, 9999.99)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string? Category { get; set; }

        public string? Notes { get; set; }
    }
}
