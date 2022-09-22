using System;
using System.ComponentModel.DataAnnotations;

namespace PycApi.Dto
{
    public class UserDto
    {

        public long Id { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        [Display(Name = "Last Activity")]
        public DateTime LastActivity { get; set; }

        public string Role { get; set; }

    }
}
