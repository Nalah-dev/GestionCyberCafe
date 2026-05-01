using Gestion_CyberCafe.Data;
using Gestion_CyberCafe.ModelsR;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace Gestion_CyberCafe.Views
{
    public partial class PosteView : UserControl
    {
        private GestionCyberContext _context;

        public PosteView()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<GestionCyberContext>()
                .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GestionCyber;Trusted_Connection=True;")
                .Options;

            _context = new GestionCyberContext(options);
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            var poste = new Poste
            {
                Numero = txtNumero.Text,
                Statut = "Libre"
            };

            _context.Postes.Add(poste);
            _context.SaveChanges();

            MessageBox.Show("Poste ajouté !");
        }
    }
}