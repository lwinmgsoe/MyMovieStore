using System.ComponentModel.DataAnnotations;

namespace MyMovieStore.Domain.Models
{
    public class Director
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        [MaxLength(255)]
        public string Gender { get; set; }
    }
}
