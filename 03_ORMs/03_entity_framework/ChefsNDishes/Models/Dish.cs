using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required]
        [MaxLength(45)]
        public string Name { get; set; }

        [Required]
        public int Tastiness { get; set; }

        [Required]
        public int Calories { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public Chef DishCreator { get; set; }

        [Required]
        public int ChefId { get; set; }
    }
}