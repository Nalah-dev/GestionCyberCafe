using Gestion_CyberCafe.Views;
using System.Windows;

namespace Gestion_CyberCafe
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClient_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ClientView();
        }
        private void BtnPoste_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new PosteView();
        }
        private void BtnSeance_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new SeanceView();
        }
    }
}