using AppiTest.Models;
using Microsoft.EntityFrameworkCore;

namespace AppiTest.Context
{
    public class HumanosContext : DbContext
    {
        public DbSet<Humanos> tHumanos { get; set; }
        
        public HumanosContext(DbContextOptions<HumanosContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("Conect");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
