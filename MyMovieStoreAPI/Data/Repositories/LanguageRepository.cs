namespace MyMovieStoreAPI.Data.Repositories
{
    public class LanguageRepository : GenericRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
