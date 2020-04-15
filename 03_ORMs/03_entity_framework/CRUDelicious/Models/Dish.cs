using System.ComponentModel.DataAnnotations;
using System;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        [Required]
        [MaxLength(11)]
        public int DishId { get; set; }

        [Required]
        [MaxLength(45)]
        public string Name { get; set; }


        [Required]
        [MaxLength(45)]
        public string Chef { get; set; }

        [Required]
        [MaxLength(11)]
        public int Tastiness { get; set; }

        [Required]
        [MaxLength(11)]
        public int Calories { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}