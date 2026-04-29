using Gestion_CyberCafe.ModelsR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Gestion_CyberCafe.Data
{
    public class GestionCyberContext : DbContext
    {
        public GestionCyberContext(DbContextOptions<GestionCyberContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ❌ STOP CASCADE PROBLEM
            foreach (var fk in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                fk.DeleteBehavior = DeleteBehavior.NoAction;
            }

            // 💰 PRECISION
            modelBuilder.Entity<Paiement>()
                .Property(p => p.Montant)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Parametre>()
                .Property(p => p.PrixHeure)
                .HasPrecision(10, 2);
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Poste> Postes { get; set; }
        public DbSet<Seance> Seances { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Connexion> Connexions { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<Parametre> Parametres { get; set; }
    }
}