using Gestion_CyberCafe.Data;
using Gestion_CyberCafe.ModelsR;
using Gestion_CyberCafe.Services;
using Gestion_CyberCafe.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Gestion_CyberCafe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var options = new DbContextOptionsBuilder<GestionCyberContext>()
    .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GestionCyber;Trusted_Connection=True;")
    .Options;

            var context = new GestionCyberContext(options);

            var service = new ClientService(context);
            var vm = new ClientViewModel(service);
           
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            vm.AjouterClient(txtNom.Text, txtPrenom.Text, txtTel.Text);
            MessageBox.Show("Client ajouté !");
        }
       

    }
}