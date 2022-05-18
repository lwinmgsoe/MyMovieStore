using System.ComponentModel.DataAnnotations;

namespace MovieStore.Domain.Models
{
    public class Actor
    {
        public int Id { get; set; }    
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
