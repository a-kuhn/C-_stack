using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models
{
    [NotMapped]
    public class LoginUser
    {
        [Required(ErrorMessage = " is required")]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = " is required")]
        public string LoginPassword { get; set; }
    }
}