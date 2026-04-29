using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gestion_CyberCafe.ModelsR
{
    public class Client
{
        [Key]
        public int IdClient { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Telephone { get; set; }

    public List<Seance> Seances { get; set; }
}
}
