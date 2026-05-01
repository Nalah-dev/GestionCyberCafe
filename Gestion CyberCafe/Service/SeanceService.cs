using Gestion_CyberCafe.Data;
using Gestion_CyberCafe.ModelsR;
using System;
using System.Linq;

namespace Gestion_CyberCafe.Services
{
    public class SeanceService
    {
        private readonly GestionCyberContext _context;
        private readonly PaiementService _paiementService;

        public SeanceService(GestionCyberContext context)
        {
            _context = context;
            _paiementService = new PaiementService(context);
        }

        // ▶ START SESSION
        public void StartSession(int clientId, int posteId)
        {
            var connexion = _context.Connexions
                .OrderByDescending(c => c.IdConnexion)
                .FirstOrDefault();

            if (connexion == null)
                throw new Exception("Aucune connexion trouvée");

            var seance = new Seance
            {
                IdClient = clientId,
                IdPoste = posteId,
                IdConnexion = connexion.IdConnexion,
                HeureDebut = DateTime.Now,
                Prolongation = 0
            };

            _context.Seances.Add(seance);

            var poste = _context.Postes.Find(posteId);
            if (poste != null)
                poste.Statut = "Occupe";

            _context.SaveChanges();
        }

        // ⏹ STOP SESSION + CALCUL + PAIEMENT
        public decimal StopSession(int idSeance)
        {
            var seance = _context.Seances.Find(idSeance);

            if (seance == null)
                return 0;

            if (seance.HeureFin != null)
                return 0;

            seance.HeureFin = DateTime.Now;

            var duree = seance.HeureFin.Value - seance.HeureDebut;
            double heures = duree.TotalHours;

            if (heures < 0)
                heures = 0;

            var param = _context.Parametres.FirstOrDefault();
            decimal prixHeure = param?.PrixHeure ?? 0;

            decimal total = (decimal)heures * prixHeure;

            var poste = _context.Postes.Find(seance.IdPoste);
            if (poste != null)
                poste.Statut = "Libre";

            // 💳 PAIEMENT CREATION
            if (total > 0)
            {
                _paiementService.CreerPaiement(seance.IdSeance, total);
            }

            _context.SaveChanges();

            return total;
        }
    }
}