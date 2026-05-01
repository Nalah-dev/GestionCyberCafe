using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gestion_CyberCafe.ModelsR
{
    public class Seance
    {
        [Key]
        public int IdSeance { get; set; }

        // ✔️ DATE + HEURE (pro style)
        public DateTime HeureDebut { get; set; }
        public DateTime? HeureFin { get; set; }

        public int Prolongation { get; set; }

        // CLIENT
        public int IdClient { get; set; }
        public Client Client { get; set; }

        // POSTE
        public int IdPoste { get; set; }
        public Poste Poste { get; set; }

        // CONNEXION
        public int IdConnexion { get; set; }
        public Connexion Connexion { get; set; }

        // PAIEMENTS
        public ICollection<Paiement> Paiements { get; set; }
    }
}