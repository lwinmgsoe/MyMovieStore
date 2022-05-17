using System.ComponentModel.DataAnnotations;
namespace MyMovieStore.Domain.Models
{
    public class Studio
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
