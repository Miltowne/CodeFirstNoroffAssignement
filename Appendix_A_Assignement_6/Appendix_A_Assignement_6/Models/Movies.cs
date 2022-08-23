using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Title { get; set; }

        [MaxLength(100)]
        [Required]
        public string Genre { get; set; }

        [Range(1800, 2022, ErrorMessage = "No year that corresponds for when they made the camera able to make a film")]
        [Required]
        public int ReleaseYear { get; set; }

        [MaxLength(50)]
        public string Director { get; set; }

        [MaxLength(100)]
        [Url]
        public string Picture { get; set; }

        [MaxLength(100)]
        [Url]
        public string Trailer { get; set; }

        public ICollection<Character> Characters { get; set; } // Many -> One

    }
}
