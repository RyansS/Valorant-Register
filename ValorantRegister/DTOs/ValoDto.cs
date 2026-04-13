using System.ComponentModel.DataAnnotations;

namespace ValorantRegister.DTOs
{
    public class ValoDto
    {

        [Required]
        [StringLength(16)]
        public string Username { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required]
        [MaxLength(5)]
        public string UserTag { get; set; }

    }
}
