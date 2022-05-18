namespace MyMovieStoreAPI.Services
{
    public interface IUnitOfWork: IDisposable
    {
        IFilmRepository Films { get; }
        ICastRepository Casts { get; }
        IActorRepository Actors { get; }
        ICertificateRepository Certificates { get;}
        ICountryRepository Countries { get; }
        IDirectorRepository Directors { get; }
        IGenereRepository Generes { get; }
        ILanguageRepository Languages { get; }
        IStudioRepository Studios { get; }
        int Complete();
    }
}
