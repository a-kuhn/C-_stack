using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdAndCat.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = " is required")]
        [MinLength(2, ErrorMessage = " must be at least 2 characters long.")]
        [MaxLength(45)]
        public string Name { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Association> ProductsInCategory { get; set; }

    }
}