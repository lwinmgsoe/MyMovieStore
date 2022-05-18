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
            Actors = new ActorRepository(_context);
            Certificates = new CertificateRepository(_context);
            Countries = new CountryRepository(_context);
            Directors = new DirectorRepository(_context);
            Generes = new GenereRepository(_context);
            Languages = new LanguageRepository(_context);
            Studios = new StudioRepository(_context);
        }
        public IFilmRepository Films { get; private set; }
        public ICastRepository Casts { get; private set; }

        public IActorRepository Actors { get; private set; }

        public ICertificateRepository Certificates { get; private set; }

        public ICountryRepository Countries { get; private set; }

        public IDirectorRepository Directors { get; private set; }

        public IGenereRepository Generes { get; private set; }

        public ILanguageRepository Languages { get; private set; }

        public IStudioRepository Studios { get; private set; }

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
