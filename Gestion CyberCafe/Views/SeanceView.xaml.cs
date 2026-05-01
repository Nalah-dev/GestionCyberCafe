using Gestion_CyberCafe.Data;
using Gestion_CyberCafe.Services;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace Gestion_CyberCafe.Views
{
    public partial class SeanceView : UserControl
    {
        private SeanceService service;

        public SeanceView()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<GestionCyberContext>()
                .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GestionCyber;Trusted_Connection=True;")
                .Options;

            var context = new GestionCyberContext(options);
            service = new SeanceService(context);
        }

        // ▶ START SESSION
        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            service.StartSession(
                int.Parse(txtClientId.Text),
                int.Parse(txtPosteId.Text)
            );

            MessageBox.Show("Session démarrée !");
        }

        // ⏹ STOP SESSION
        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            int idSeance = int.Parse(txtSeanceId.Text);

            decimal total = service.StopSession(idSeance);

            MessageBox.Show($"Total à payer : {total}");
        }
    }
}