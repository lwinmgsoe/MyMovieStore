using Microsoft.EntityFrameworkCore;
using MovieStore.Domain.Models;

namespace MyMovieStoreAPI.Data.Repositories
{
    public class CastRepository : GenericRepository<Cast>, ICastRepository
    {
        private readonly ApplicationContext context;

        public CastRepository(ApplicationContext context) : base(context)
        {
            this.context = context;
        }
        public override IEnumerable<Cast> GetAll()
        {
            var casts = context.Casts.Include(cast => cast.Actor);
            return casts;
        }

        public IEnumerable<BasicActorCast> GetAllBasicActorCast()
        {
            var casts = context.Casts.Include(cast => cast.Actor).Select(x=> new BasicActorCast()
            {
                Id = x.ActorId,
                ActorName = x.Actor.Name,
                CastName = x.CastCaracterName
            });
            return casts;
        }

        public IEnumerable<BasicActorCast> GetAllBasicActorCastByFilmId(int id)
        {
            var casts = context.Casts.Where(x=>x.FilmId == id).Include(cast => cast.Actor).Select(x => new BasicActorCast()
            {
                Id = x.ActorId,
                ActorName = x.Actor.Name,
                CastName = x.CastCaracterName
            });
            return casts;
        }

        public BasicActorCast GetBasicActorCast(int id)
        {
            var cast = context.Casts.Where(x => x.Id == id).Include(cast => cast.Actor).Select(x => new BasicActorCast()
            {
                Id = x.ActorId,
                ActorName = x.Actor.Name,
                CastName = x.CastCaracterName
            }).FirstOrDefault();
            return cast;
        }

        public override Cast GetById(int id)
        {
            var cast = context.Casts.Where(x=>x.Id == id).Include(cast => cast.Actor).FirstOrDefault();
            return cast;
        }
    }
}
