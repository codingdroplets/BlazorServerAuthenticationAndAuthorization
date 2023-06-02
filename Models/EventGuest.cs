using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppProjekt.Models
{
    [Table("eventguest")]
    public class EventGuest
    {
        [Column("idguest")]
        public int GuestId { get; set; }

        [Column("idevent")]
        public int EventId { get; set; }

        [Key]
        [Column("EventGuestId")]
        public int EventGuestId { get; set; }


        [ForeignKey("GuestId")]
        public Guest Guest { get; set; }

        [ForeignKey("EventId")]
        public Event Event { get; set; }

    }
}

