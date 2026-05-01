using Gestion_CyberCafe.Data;
using Gestion_CyberCafe.ModelsR;
using System;

namespace Gestion_CyberCafe.Services
{
    public class PaiementService
    {
        private readonly GestionCyberContext _context;

        public PaiementService(GestionCyberContext context)
        {
            _context = context;
        }

        public Paiement CreerPaiement(int idSeance, decimal montant)
        {
            var paiement = new Paiement
            {
                IdSeance = idSeance,
                Montant = montant,
                DatePaiement = DateTime.Now,
                ModePaiement = "Cash",
                Statut = "En attente"
            };

            _context.Paiements.Add(paiement);
            _context.SaveChanges();

            return paiement;
        }

        public void ValiderPaiement(int idPaiement)
        {
            var paiement = _context.Paiements.Find(idPaiement);

            if (paiement != null)
            {
                paiement.Statut = "Payé";
                _context.SaveChanges();
            }
        }
    }
}