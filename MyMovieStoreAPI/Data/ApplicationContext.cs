using Microsoft.EntityFrameworkCore;

namespace MyMovieStoreAPI.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Genere> Generes { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Studio> Studios { get; set; }

    }
}
