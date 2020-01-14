namespace AspNetCoreBestPractices.Database
{
    using Microsoft.EntityFrameworkCore;

    public class StarshipsContext : DbContext
    {
        public StarshipsContext(DbContextOptions<StarshipsContext> options) : base(options)
        {

        }

        public DbSet<Starship> Starships { get; set; }
    }
}
