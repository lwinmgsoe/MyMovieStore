using System.ComponentModel.DataAnnotations;

namespace MovieStore.Domain.DTOS
{
    public class FilmDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public int DirectorId { get; set; }
        [Required]
        public int LanguageId { get; set; }
        [Required]
        public int CountryId { get; set; }
        [Required]
        public int StudioId { get; set; }
        [Required]
        public string Synopsis { get; set; }
        public int RunTimeMinutes { get; set; }
        [Required]
        public int CertificateId { get; set; }
        
        public int BudgetDollars { get; set; }
        public int BoxOfficeDollars { get; set; }
        public int OscarNominations { get; set; }
        public int OscarWins { get; set; }
        
    }
}
