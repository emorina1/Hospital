using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Entities
{
    public enum Department
    {
        Cardiology,
        Neurology,
        Pediatrics,
        GeneralPractice
    }

    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public ICollection<Pacient> Pacients { get; set; }

        public Department Departamenti { get; set; }

        // Ose orari i punës
        public DateTime Termini { get; set; }

        public string CoverImage { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedDate { get; set; }
    }
}
