using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_CyberCafe.Data;
using Gestion_CyberCafe.ModelsR;


namespace Gestion_CyberCafe.Services
{
    public class ClientService
    {
        private readonly GestionCyberContext _context;

        public ClientService(GestionCyberContext context)
        {
            _context = context;
        }

        public void AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }
    }
}
