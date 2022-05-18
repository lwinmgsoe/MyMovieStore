namespace MyMovieStoreAPI.Data.Repositories
{
    public class StudioRepository : GenericRepository<Studio>, IStudioRepository
    {
        public StudioRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
