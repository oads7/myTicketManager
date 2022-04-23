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

        private void DepartureText_Changed(object sender, RoutedEventArgs e)
        {
            DateTime time = DateTime.Parse(DepartureTime.Text);

            DepartureDate.DisplayDate.AddHours(time.Hour);
            DepartureDate.DisplayDate.AddMinutes(time.Minute);
            DepartureDate.DisplayDate.AddSeconds(time.Second);
        }

        private void ArriveDate_DateChanged(object sender, RoutedEventArgs e)
        {
            DepartureTime.Text = DepartureDate.DisplayDate.ToShortTimeString();
        }

        private void ArriveText_Changed(object sender, RoutedEventArgs e)
        {
            DateTime time = DateTime.Parse(DepartureTime.Text);

            DepartureDate.DisplayDate.AddHours(time.Hour);
            DepartureDate.DisplayDate.AddMinutes(time.Minute);
            DepartureDate.DisplayDate.AddSeconds(time.Second);
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
