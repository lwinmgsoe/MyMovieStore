using System.ComponentModel.DataAnnotations;

namespace MovieStore.Domain.Models
{
    public class Certificate
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string CertificateName { get; set; }
    }
}
