using System.ComponentModel.DataAnnotations;

namespace ValorantRegister.Model
{
    public class ValoRegister
    {
        [Key]
        [Required]
        public int Id { get; set;  }

        [Required]
        [MaxLength(16)]
        public string Username { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required]
        [MaxLength(5)]
        public string UserTag { get; set; }

    }
}
