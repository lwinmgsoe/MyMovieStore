namespace MyMovieStoreAPI.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Films = new FilmRepository(_context);
            Casts = new CastRepository(_context);
        }
        public IFilmRepository Films { get; private set; }
        public ICastRepository Casts { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
