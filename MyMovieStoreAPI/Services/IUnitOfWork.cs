namespace MyMovieStoreAPI.Services
{
    public interface IUnitOfWork: IDisposable
    {
        IFilmRepository Films { get; }
        ICastRepository Casts { get; }
        int Complete();
    }
}
