namespace MyMovieStoreAPI.Data.Repositories
{
    public class CertificateRepository : GenericRepository<Certificate>, ICertificateRepository
    {
        public CertificateRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
