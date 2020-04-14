using System;
using System.ComponentModel.DataAnnotations;

namespace LoginReg.Models
{
    public class RegUser
    {
        [Required]
        [MinLength(2)]
        public string RegFirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string RegLastName { get; set; }

        [Required]
        [EmailAddress]
        public string RegEmail { get; set; }

        [Required]
        [MinLength(8)]
        public string RegPassword { get; set; }

        [Required]
        [Compare(nameof(RegPassword))]
        public string RegPWConfirm { get; set; }
    }
}