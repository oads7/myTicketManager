using myTicketManager.Controllers;
using myTicketManager.Entities;
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
using System.Windows.Shapes;

namespace myTicketManager.View
{
    /// <summary>
    /// Lógica de interacción para Lobby.xaml
    /// </summary>
    public partial class Lobby : Window
    {
        public Lobby()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UserWelcome.HorizontalContentAlignment = HorizontalAlignment.Right;
            UserWelcome.Content = "Bienvenido " + Sessions.Current().fullname;

            FlightDataGrid.ItemsSource = await FlightList.GetList(100);
            FlightDataGrid.Columns[0].Header = "Flight";
            FlightDataGrid.Columns[1].Header = "Airline Company";
            FlightDataGrid.Columns[2].Header = "Source";
            FlightDataGrid.Columns[3].Header = "Destiny";
            FlightDataGrid.Columns[4].Header = "Departure Time";
            FlightDataGrid.Columns[5].Header = "Arrive Time";
            FlightDataGrid.Columns[6].Header = "Flight State";
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void EditFlight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewFlight_Click(object sender, RoutedEventArgs e)
        {
            FlightDialog flightDialog = new FlightDialog();
            flightDialog.ShowDialog();

            Flight item = new Flight();

            flightDialog.Closed += (sender, args) =>
            {
                item.numFlight = flightDialog.Flight.Text;
                item.airline = flightDialog.Airline.Text;
                item.source = flightDialog.Source.Text;
                item.destiny = flightDialog.Destiny.Text;
                item.departureDate = flightDialog.DepartureDate.DisplayDate;
                item.arriveDate = flightDialog.ArriveDate.DisplayDate;
                item.state = flightDialog.State.Text;

                FlightList.AddFlight(item);

                flightDialog.Close();
            };
                
                /*
                (sender, args) =>
            {
                item.numFlight = flightDialog.Flight.Text;
                item.airline = flightDialog.Airline.Text;
                item.source = flightDialog.Source.Text;
                item.destiny = flightDialog.Destiny.Text;
                item.departureDate = flightDialog.DepartureDate.DisplayDate;
                item.arriveDate = flightDialog.ArriveDate.DisplayDate;
                item.state = flightDialog.State.Text;

                FlightList.AddFlight(item);
            };
                */
        }

        private void DeleteFlight_Click(object sender, RoutedEventArgs e)
        {
            int index = FlightDataGrid.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Please, select one flight from table.");
                return;
            }

            Flight element = (Flight)FlightDataGrid.Items[index];

            FlightList.DeleteFlight(element.numFlight);
            FlightDataGrid.Items.RemoveAt(index);
        }
    }
}
