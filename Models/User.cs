using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppProjekt.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("iduser")]
        public int Id { get; set; }
        public string UserName { get; set; }

        [Column("userpassword")]
        public string Password { get; set; }

        [Column("realname")]
        public string FullName { get; set; }

        [Column("userlevel")]
        public string userlevel { get; set; }
    }
}
