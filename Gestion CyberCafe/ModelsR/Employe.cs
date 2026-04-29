using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gestion_CyberCafe.ModelsR
{
    public class Employe
    {
        [Key]
        public int IdEmploye { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public List<Connexion> Connexions { get; set; }
    }
}
