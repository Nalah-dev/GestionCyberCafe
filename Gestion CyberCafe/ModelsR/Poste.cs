using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gestion_CyberCafe.ModelsR
{
    public class Poste
    {
        [Key]
        public int IdPoste { get; set; }
        public string Numero { get; set; }
        public string Statut { get; set; } = "Libre";

        public List<Seance> Seances { get; set; }
        public List<Connexion> Connexions { get; set; }
    }
}
