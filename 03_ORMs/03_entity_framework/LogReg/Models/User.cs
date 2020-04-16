using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogReg.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = " is required")]
        [MinLength(2, ErrorMessage = " must be at least 2 characters long.")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = " must be at least 2 characters long.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = " is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = " is required")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = " must be at least 8 characters long.")]
        public string Password { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string PWConfirm { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
