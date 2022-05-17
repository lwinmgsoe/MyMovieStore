using System.ComponentModel.DataAnnotations;

namespace MyMovieStore.Domain.Models
{
    public class Genere
    {
        public int Id { get; set; } 
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
