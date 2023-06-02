using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppProjekt.Models
{
    // Models/Guest.cs
    [Table("guest")]
    public class Guest
    {
        [Key]
        [Column("idguest")]
        public int Id { get; set; }

        [Column("name")]
        [MaxLength(45)]
        public string Name { get; set; }

        [Column("title")]
        [MaxLength(45)]
        public string Title { get; set; }

        [Column("datetime", TypeName = "date")]
        public DateTime Date { get; set; }

        [Column("mobil")]
        [MaxLength(45)]
        public string Mobile { get; set; }

        [Column("email")]
        [MaxLength(45)]
        public string Email { get; set; }

        [Column("note")]
        [MaxLength(45)]
        public string? Note { get; set; } // Módosítottam, hogy nullable string legyen

        [Column("picture")]
        [MaxLength(45)]
        public string Picture { get; set; }
    }
}
