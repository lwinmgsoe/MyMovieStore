using System.ComponentModel.DataAnnotations;
namespace MovieStore.Domain.Models
{
    public class Studio
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
