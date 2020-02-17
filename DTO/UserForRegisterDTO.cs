using System.ComponentModel.DataAnnotations;
namespace DatingApp.API.DTO
{
    public class UserForRegisterDTO
    {
        [Required]
        public string Username {get; set;}
        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage = "Password must be 4 to 8 chars !")]
        public string Password { get; set; }
    }
}