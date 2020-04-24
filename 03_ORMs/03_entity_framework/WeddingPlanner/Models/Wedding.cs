using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }

        [Required]
        public string Wedder1 { get; set; }

        [Required]
        public string Wedder2 { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int CreatedById { get; set; }

        [Required]
        public User CreatedBy { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<RSVP> Attendees { get; set; }

    }
}