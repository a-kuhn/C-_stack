using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }

        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]
        [FutureDate]
        [MinAge]
        public DateTime DoB { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Dish> ChefsDishes { get; set; }


        public int Age()
        {
            int age = (int.Parse(DateTime.Now.ToString("yyyyMMdd")) - int.Parse(DoB.ToString("yyyyMMdd"))) / 10000;
            return age;
        }
    }
}