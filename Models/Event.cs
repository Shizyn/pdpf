﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuantumEvents.Models
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey("ProfProba")]
        public int ProfProbaId { get; set; }
        public ProfProba ProfProba { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    }
}
