using System.ComponentModel.DataAnnotations;

namespace vscode_spice.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}