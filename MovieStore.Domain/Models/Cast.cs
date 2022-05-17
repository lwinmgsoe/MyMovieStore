using System.ComponentModel.DataAnnotations;

namespace MyMovieStore.Domain.Models
{
    public class Cast
    {
        public int Id { get; set; }
        [Required]
        public int FilmId { get; set; }
        [Required]
        public int ActorId { get; set; }
        
        public Actor Actor { get; set; }
        [MaxLength(255)]
        public string CastCaracterName { get; set; }
    }
}
