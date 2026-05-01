using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_CyberCafe.ModelsR
{
    public class Connexion
    {
        [Key]
        public int IdConnexion { get; set; }

        public DateTime DateConnexion { get; set; }
        public TimeSpan HeureConnexion { get; set; }

        public string Statut { get; set; }

        // 🔵 FK POSTE
        public int IdPoste { get; set; }
        [ForeignKey("IdPoste")]
        public Poste Poste { get; set; }

        // 🔵 FK EMPLOYE
        public int IdEmploye { get; set; }
        [ForeignKey("IdEmploye")]
        public Employe Employe { get; set; }

        // 🔵 LIST SEANCES
        public List<Seance> Seances { get; set; }
    }
}