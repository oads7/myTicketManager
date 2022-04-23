using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using myTicketManager.Models;
using myTicketManager.Controllers;
using myTicketManager.View;

namespace myTicketManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeLog();
            Database.InitializeDatabase();

            InitializeComponent();
        }

        private void InitializeLog()
        {
            Log.Init("log.txt");
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            bool res = await LoginValidate.StartSessionAsync(Username.Text, Password.Text);
            if (res)
            {
                
            }
            else
                MessageBox.Show("Invalid user or password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            Lobby lobby = new Lobby();
            lobby.Show();

            this.Hide();
        }
    }
}
