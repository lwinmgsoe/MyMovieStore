using Microsoft.EntityFrameworkCore;

namespace MyMovieStoreAPI.Data.Repositories
{
    public class FilmRepository : GenericRepository<Film>, IFilmRepository
    {
        private readonly ApplicationContext context;

        public FilmRepository(ApplicationContext context) : base(context)
        {
            this.context = context;
        }
        public override IEnumerable<Film> GetAll()
        {
            var films = context.Films
                .Include(film => film.Director)
                .Include(film => film.Country)
                .Include(film => film.Language)
                .Include(film => film.Studio)                
                .ToList();
            return films;
        }
        public override Film GetById(int id)
        {
            var _film = context.Films.Where(film => film.Id == id)
                .Include(film => film.Director)
                .Include(film => film.Country)
                .Include(film => film.Language)
                .Include(film => film.Studio)
                .FirstOrDefault();
            return _film;
        }
    }
}
