using System.ComponentModel.DataAnnotations;

namespace MovieStore.Domain.Models
{
    public class Country
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
