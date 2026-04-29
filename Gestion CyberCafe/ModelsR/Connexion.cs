using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gestion_CyberCafe.ModelsR
{
    public class Connexion
    {
        [Key]
        public int IdConnexion { get; set; }
        public DateTime DateConnexion { get; set; }
        public TimeSpan HeureConnexion { get; set; }
        public string Statut { get; set; }

        public int IdPoste { get; set; }
        public int IdEmploye { get; set; }

        public Poste Poste { get; set; }
        public Employe Employe { get; set; }

        public List<Seance> Seances { get; set; }
    }
}
