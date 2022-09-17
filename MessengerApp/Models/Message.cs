using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessengerApp.Models
{
    [Table("Messages")]
    public class Message
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string BodyMessage { get; set; }

        [Required]
        [ForeignKey("Sender")]
        public Guid SenderId { get; set; }

        [Required]
        public ICollection<User> Receivers { get; set; }




    }
}
