using System.ComponentModel.DataAnnotations;

namespace PycApi.Base
{
    public class TokenRequest
    {
        [Required]
        [EmailAttribute]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required]
        [PasswordAttribute]
        public string Password { get; set; }
    }
}
