using System;
using System.ComponentModel.DataAnnotations;
using FormSubmission.Validations;
namespace FormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(4)]
        public string LastName { get; set; }

        [Required]
        [Range(0, 1000)]
        public int Age { get; set; }

        [FutureDateAttribute]
        public DateTime Birthday { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        public User() { }
        public User(User newUser)
        {
            FirstName = newUser.FirstName;
            LastName = newUser.LastName;
            Age = newUser.Age;
            Email = newUser.Email;
            Password = newUser.Password;
        }
    }
}