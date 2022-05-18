namespace MyMovieStoreAPI.Data.Repositories
{
    public class GenereRepository : GenericRepository<Genere>, IGenereRepository
    {
        public GenereRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
