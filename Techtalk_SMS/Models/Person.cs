using System.ComponentModel.DataAnnotations;

namespace Techtalk_SMS.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string Name { get; set; }
        [Range(1, 150, ErrorMessage = "Age must be between 1 and 150.")]
        public int Age { get; set; }
    }
}

