using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Input;

namespace Gestion_CyberCafe.ModelsR
{
    public class Paiement
    {
        [Key]
        public int IdPaiement { get; set; }

        public decimal Montant { get; set; }
        public DateTime DatePaiement { get; set; }
        public string ModePaiement { get; set; }
        public string Statut { get; set; }

        public int IdSeance { get; set; }
        public Seance Seance { get; set; }
    }
}
