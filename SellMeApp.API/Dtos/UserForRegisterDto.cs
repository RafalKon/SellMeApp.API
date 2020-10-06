using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SellMeApp.API.Dtos
{
    public class UserForRegisterDto
    {

        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane!")]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "Hasło musi zawierać od 4 do 8 znaków")]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}
