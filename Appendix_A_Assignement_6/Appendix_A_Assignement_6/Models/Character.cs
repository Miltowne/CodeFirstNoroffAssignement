using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Alias { get; set; }

        [MaxLength(50)]
        public Gender Gender { get; set; }

        [MaxLength(50)]
        [Url]
        public string Picture { get; set; }

        public ICollection<Movies> Movies { get; set; } // Many -> many,one?
    }
}
