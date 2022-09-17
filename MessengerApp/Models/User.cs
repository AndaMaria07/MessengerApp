using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MessengerApp.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [JsonIgnore]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [JsonIgnore]
        public string? AccesToken { get; set; }

        [JsonIgnore]
        public ICollection<Message>? Messages { get; set; } = null!;
    }

}
