using Gestion_CyberCafe.Data;
using System;
using System.Linq;

namespace Gestion_CyberCafe.Services
{
    public class CaisseService
    {
        private readonly GestionCyberContext _context;

        public CaisseService(GestionCyberContext context)
        {
            _context = context;
        }

        // 💰 TOTAL PAR JOUR
        public decimal GetTotalAujourdhui()
        {
            var today = DateTime.Today;

            return _context.Paiements
                .Where(p => p.DatePaiement.Date == today && p.Statut == "Payé")
                .Sum(p => (decimal?)p.Montant) ?? 0;
        }

        // 📊 TOTAL GLOBAL
        public decimal GetTotalGlobal()
        {
            return _context.Paiements
                .Where(p => p.Statut == "Payé")
                .Sum(p => (decimal?)p.Montant) ?? 0;
        }
    }
}