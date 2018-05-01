using System.ComponentModel.DataAnnotations;


namespace form.Models
{
    public class User
    {
        [Required(ErrorMessage = "WHERE IS YOUR NAMEEEE????????")]
        [MinLength(4)]
        public string first_name { get; set; }
        [Required]
        [MinLength(4)]
        public string last_name { get; set; }
        [Required]
        [Range(1, 200)]
        public int age { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}