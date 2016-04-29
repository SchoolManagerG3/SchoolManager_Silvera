using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Fältet måste fyllas")]
        [Display(Name = "Användarnamn")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Fältet måste fyllas")]
        [Display(Name = "Lösenord")]
        public string Password { get; set; }

    }
}
