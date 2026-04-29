using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gestion_CyberCafe.ModelsR
{
    public class Seance
    {
        [Key]
        public int IdSeance { get; set; }

        public TimeSpan HeureDebut { get; set; }
        public TimeSpan HeureFin { get; set; }
        public int Prolongation { get; set; }

        public int IdClient { get; set; }
        public int IdPoste { get; set; }
        public int IdConnexion { get; set; }
    }
}
