using MovieStore.Domain.DTOS;
using MovieStore.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace MovieStore.Domain.Models
{
    public class Film
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }        
        public int StudioId { get; set; }
        public Studio Studio { get; set; }
        public string Synopsis { get; set; }
        public int RunTimeMinutes { get; set; }
        public int CertificateId { get; set; }
        public Certificate Certificate { get; set; }
        public int BudgetDollars { get; set; }
        public int BoxOfficeDollars { get; set; }
        public int OscarNominations { get; set; }
        public int OscarWins { get; set; }
        public List<BasicActorCast> Casts { get; set; }
        public Film()
        {
            Casts = new List<BasicActorCast>();
        }
        public Film(FilmDTO dto)
        {
            Id = dto.Id;
            Name = dto.Name;
            DirectorId = dto.DirectorId;
            LanguageId = dto.LanguageId;
            CountryId = dto.CountryId;
            StudioId = dto.StudioId;
            Synopsis = dto.Synopsis;
            RunTimeMinutes = dto.RunTimeMinutes;
            CertificateId = dto.CertificateId;
            BudgetDollars = dto.BudgetDollars;
            BoxOfficeDollars = dto.BoxOfficeDollars;
            OscarNominations = dto.OscarNominations;
            OscarWins = dto.OscarWins;
        }
    }
}
