using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Field Missing")]
        [MaxLength(100, ErrorMessage = "Category Name must be below 100 characters")]
        [DisplayName("Category Name")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Field Missing")]
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
