using System;
using System.ComponentModel.DataAnnotations;

namespace Gestion_CyberCafe.ModelsR
{
    public class Paiement
    {
        [Key]
        public int IdPaiement { get; set; }

        public decimal Montant { get; set; }

        // ✔ automatique rehefa création
        public DateTime DatePaiement { get; set; } = DateTime.Now;

        public string ModePaiement { get; set; }

        public string Statut { get; set; } = "En attente";

        // FK obligatoire
        public int IdSeance { get; set; }

        // navigation property
        public Seance Seance { get; set; }
    }
}