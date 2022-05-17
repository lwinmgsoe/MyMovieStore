using MovieStore.Domain.Models;

namespace MyMovieStoreAPI.Data.Interfaces
{
    public interface ICastRepository : IGenericRepository<Cast>
    {
        IEnumerable<BasicActorCast> GetAllBasicActorCast();
        IEnumerable<BasicActorCast> GetAllBasicActorCastByFilmId(int id);
        BasicActorCast GetBasicActorCast(int id);
    }
}
