using Gestion_CyberCafe.Data;
using Gestion_CyberCafe.Services;
using Gestion_CyberCafe.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace Gestion_CyberCafe.Views
{
    public partial class ClientView : UserControl
    {
        private ClientViewModel vm;

        public ClientView()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<GestionCyberContext>()
                .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GestionCyber;Trusted_Connection=True;")
                .Options;

            var context = new GestionCyberContext(options);
            var service = new ClientService(context);

            vm = new ClientViewModel(service);
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            vm.AjouterClient(txtNom.Text, txtPrenom.Text, txtTel.Text);
            MessageBox.Show("Client ajouté !");
        }
    }
}