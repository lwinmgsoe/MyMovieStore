namespace MyMovieStoreAPI.Data
{
    public static class AddDataServices
    {
        public static void RegisterDataService(this WebApplicationBuilder builder)
        {
            builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddTransient<IFilmRepository, FilmRepository>();
        }
    }
}
