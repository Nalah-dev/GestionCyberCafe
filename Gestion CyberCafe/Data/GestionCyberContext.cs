using Gestion_CyberCafe.ModelsR;
using Microsoft.EntityFrameworkCore;

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

            // 💰 PRECISION MONEY
            modelBuilder.Entity<Paiement>()
                .Property(p => p.Montant)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Parametre>()
                .Property(p => p.PrixHeure)
                .HasPrecision(10, 2);

            // 🔗 SEANCE RELATIONS CLEAN (IMPORTANT)
            modelBuilder.Entity<Seance>()
                .HasOne(s => s.Client)
                .WithMany()
                .HasForeignKey(s => s.IdClient)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Seance>()
                .HasOne(s => s.Poste)
                .WithMany()
                .HasForeignKey(s => s.IdPoste)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Seance>()
                .HasOne(s => s.Connexion)
                .WithMany()
                .HasForeignKey(s => s.IdConnexion)
                .OnDelete(DeleteBehavior.NoAction);
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