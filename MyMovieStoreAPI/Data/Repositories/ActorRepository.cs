namespace MyMovieStoreAPI.Data.Repositories
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
