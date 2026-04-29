using Gestion_CyberCafe.ModelsR;
using Gestion_CyberCafe.Services;

namespace Gestion_CyberCafe.ViewModels
{
    public class ClientViewModel
    {
        private readonly ClientService _service;

        public ClientViewModel(ClientService service)
        {
            _service = service;
        }

        public void AjouterClient(string nom, string prenom, string tel)
        {
            _service.AddClient(new Client
            {
                Nom = nom,
                Prenom = prenom,
                Telephone = tel
            });
        }
    }
}