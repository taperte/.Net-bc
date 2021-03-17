using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAppWeb.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display (Name = "Username")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Repeat e-mail")]
        [DataType(DataType.EmailAddress)]
        [Compare(nameof(Email), ErrorMessage = "E-mails don't match.")]
        public string RepeatEmail { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Repeat password")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Passwords don't match.")]
        public string RepeatPassword { get; set; }
    }
}
