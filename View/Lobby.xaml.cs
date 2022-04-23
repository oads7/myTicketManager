using myTicketManager.Controllers;
using myTicketManager.Entities;
using System;
using System.Collections;
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

            ICollection<Flight> list = await FlightList.GetList(100);
            FlightDataGrid.ItemsSource = list;

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
            Application.Current.Shutdown();
        }

        private void EditFlight_Click(object sender, RoutedEventArgs e)
        {
            int index = FlightDataGrid.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Please, select one flight from table.");
                return;
            }

            Flight element = (Flight)FlightDataGrid.Items[index];

            // Open edit dialog
            FlightDialog flightDialog = new FlightDialog();
            flightDialog.Complete = async (resultFlight) =>
            {
                FlightList.UpdateFlight(resultFlight);

                ICollection<Flight> list = await FlightList.GetList(100);
                FlightDataGrid.ItemsSource = list;

                FlightDataGrid.Columns[0].Header = "Flight";
                FlightDataGrid.Columns[1].Header = "Airline Company";
                FlightDataGrid.Columns[2].Header = "Source";
                FlightDataGrid.Columns[3].Header = "Destiny";
                FlightDataGrid.Columns[4].Header = "Departure Time";
                FlightDataGrid.Columns[5].Header = "Arrive Time";
                FlightDataGrid.Columns[6].Header = "Flight State";

            };

            flightDialog.Title = "Update Selected Flight";
            flightDialog.Flight.Text = element.numFlight;
            flightDialog.Flight.IsReadOnly = true;
            flightDialog.Airline.Text = element.airline;
            flightDialog.Source.Text = element.source;
            flightDialog.Destiny.Text = element.destiny;

            flightDialog.DepartureDate.SelectedDate = element.departureDate;
            flightDialog.DepartureTime.Text = element.departureDate.ToShortTimeString();
            flightDialog.ArriveDate.SelectedDate = element.arriveDate;
            flightDialog.ArriveTime.Text = element.arriveDate.ToShortTimeString();

            flightDialog.State.SelectedValue = element.state;

            flightDialog.ShowDialog();
        }

        private void NewFlight_Click(object sender, RoutedEventArgs e)
        {
            FlightDialog flightDialog = new FlightDialog();
            flightDialog.Complete = (resultFlight) =>
            {
                FlightList.AddFlight(resultFlight);
                FlightDataGrid.Items.Add(resultFlight);
            };
            flightDialog.Title = "Register New Flight";
            flightDialog.ShowDialog();
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
