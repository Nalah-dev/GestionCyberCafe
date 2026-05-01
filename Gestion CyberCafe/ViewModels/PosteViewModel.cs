using Gestion_CyberCafe.Services;

namespace Gestion_CyberCafe.ViewModels
{
    public class PosteViewModel
    {
        private readonly PosteService _service;

        public PosteViewModel(PosteService service)
        {
            _service = service;
        }

        public void AjouterPoste(string numero)
        {
            _service.AddPoste(numero);
        }
    }
}