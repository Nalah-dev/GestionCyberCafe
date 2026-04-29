using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_CyberCafe.ModelsR
{
    public class Parametre
    {
        [Key]
        public int IdParametre { get; set; }
        public string NomSysteme { get; set; }
        public decimal PrixHeure { get; set; }
        public string Devise { get; set; }
    }
}
