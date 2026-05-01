using Gestion_CyberCafe.Data;
using Gestion_CyberCafe.Services;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace Gestion_CyberCafe.Views
{
    public partial class CaisseView : UserControl
    {
        private CaisseService service;

        public CaisseView()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<GestionCyberContext>()
                .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GestionCyber;Trusted_Connection=True;")
                .Options;

            var context = new GestionCyberContext(options);
            service = new CaisseService(context);

            LoadData();
        }

        private void LoadData()
        {
            txtToday.Text = "Aujourd'hui : " + service.GetTotalAujourdhui() + " Ar";
            txtTotal.Text = "Total global : " + service.GetTotalGlobal() + " Ar";
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}