namespace MyMovieStoreAPI.Data.Repositories
{
    public class DirectorRepository : GenericRepository<Director>, IDirectorRepository
    {
        public DirectorRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
