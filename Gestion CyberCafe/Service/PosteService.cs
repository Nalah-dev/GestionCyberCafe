using Gestion_CyberCafe.Data;
using Gestion_CyberCafe.ModelsR;

namespace Gestion_CyberCafe.Services
{
    public class PosteService
    {
        private readonly GestionCyberContext _context;

        public PosteService(GestionCyberContext context)
        {
            _context = context;
        }

        // ➕ Ajouter poste
        public void AddPoste(string numero)
        {
            var poste = new Poste
            {
                Numero = numero,
                Statut = "Libre"
            };

            _context.Postes.Add(poste);
            _context.SaveChanges();
        }

        //  Liste
        public List<Poste> GetAll()
        {
            return _context.Postes.ToList();
        }
    }
}