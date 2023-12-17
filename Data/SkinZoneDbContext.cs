using Microsoft.EntityFrameworkCore;
using SkinZoneAppWeb.Models;

namespace SkinZoneAppWeb.Data
{
    public class SkinZoneDbContext : DbContext
    {
        public DbSet<Skin> Skin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var stringConn = config.GetConnectionString("StringConn");

            optionsBuilder.UseSqlServer(stringConn);
        }
    }
}
