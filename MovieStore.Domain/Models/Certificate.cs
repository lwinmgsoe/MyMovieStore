using System.ComponentModel.DataAnnotations;

namespace MyMovieStore.Domain.Models
{
    public class Certificate
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string CertificateName { get; set; }
    }
}
