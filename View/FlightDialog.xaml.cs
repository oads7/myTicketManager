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
    /// Lógica de interacción para FlightDialog.xaml
    /// </summary>
    public partial class FlightDialog : Window
    {
        public delegate void FlightTransaction(Flight flight);
        public FlightTransaction Complete;


        public FlightDialog()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            State.Items.Add(FlightState.Waiting);
            State.Items.Add(FlightState.Boarding);
            State.Items.Add(FlightState.Flying);
            State.Items.Add(FlightState.Finished);
        }

        private void DepartureDate_DateChanged(object sender, RoutedEventArgs e)
        {
            DepartureTime.Text = DepartureDate.DisplayDate.ToShortTimeString();
        }

        private void DepartureTime_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime.Parse(DepartureTime.Text);
            }
            catch
            {
                MessageBox.Show("Error: Invalid Hour");
            }
        }

        private void ArriveDate_DateChanged(object sender, RoutedEventArgs e)
        {
            ArriveTime.Text = ArriveDate.DisplayDate.ToShortTimeString();
        }

        private void ArriveTime_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime.Parse(ArriveTime.Text);
            }
            catch
            {
                MessageBox.Show("Error: Invalid Hour");
            }
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Flight.Text) ||
                string.IsNullOrEmpty(Airline.Text) ||
                string.IsNullOrEmpty(Source.Text) ||
                string.IsNullOrEmpty(Destiny.Text) ||
                !DepartureDate.SelectedDate.HasValue ||
                !ArriveDate.SelectedDate.HasValue ||
                string.IsNullOrEmpty(State.Text))
            {
                MessageBox.Show("Error: Incompleted fields.");
                return;
            }

            DateTime Departure = DateTime.Parse(DepartureDate.SelectedDate.Value.ToShortDateString() + " " + DepartureTime.Text);
            DateTime Arrive = DateTime.Parse(ArriveDate.SelectedDate.Value.ToShortDateString() + " " + ArriveTime.Text); ;


            Flight item = new Flight();

            item.numFlight = Flight.Text;
            item.airline = Airline.Text;
            item.source = Source.Text;
            item.destiny = Destiny.Text;
            item.departureDate = Departure;
            item.arriveDate = Arrive;
            item.state = State.Text;

            MessageBox.Show(Departure.ToString());

            //FlightList.AddFlight(item);
            Complete(item);
        }
    }
}
