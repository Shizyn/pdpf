﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuantumEvents.Models
{
    [Table("ProfProby")]
    public class ProfProba
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Навигация на связанные события
        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
