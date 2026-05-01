using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Gestion_CyberCafe.Data
{
    public class GestionCyberContextFactory : IDesignTimeDbContextFactory<GestionCyberContext>
    {
        public GestionCyberContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GestionCyberContext>();

            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=GestionCyber;Trusted_Connection=True;"
            );

            return new GestionCyberContext(optionsBuilder.Options);
        }
    }
}