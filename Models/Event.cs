using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppProjekt.Models
{
    [Table("occurrence")]
    public class Event
    {
        [Key]
        [Column("idevent")]
        public int Id { get; set; }

        [Column("eventname")]
        [MaxLength(45)]
        public string EventName { get; set; }

        [Column("eventdescription")]
        [MaxLength(45)]
        public string EventDescription { get; set; }

        [Column("date")]
        public DateTime EventDate { get; set; }
    }
}

