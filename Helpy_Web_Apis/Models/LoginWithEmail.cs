using System.ComponentModel.DataAnnotations;

namespace Helpy_Web_Apis.Models
{
    public class LoginWithEmail
    {
        [Key] // This attribute specifies the primary key
        public int Id { get; set; }

        [Required] // Ensures email is not null in the database
        public string Email { get; set; }

        [Required] // Ensures password is not null in the database
        public string Password { get; set; }
    }
}
