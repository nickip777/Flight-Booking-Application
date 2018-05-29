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
using System.Data;

namespace cmpt300a7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private sqlDB db;
        public MainWindow()
        {
            InitializeComponent();
            
            db = new sqlDB();
            flightInstanceComboBox.ItemsSource = db.getFlightCodes();
            //db.queryFlightInstance();
        }

        private void passengerBtn_Click(object sender, RoutedEventArgs e) {
            AddPassenger window = new AddPassenger();
            window.ShowDialog();
            string firstName = window.getFirstName();
            string lastName = window.getLastName();
            if (firstName != null && lastName != null) {
                addPassenger(firstName, lastName);
            }
        }

        private void addPassenger(string first, string last) {
            //add to db 
            int pid = db.getHighestPid() + 1;
            pidMsg.Content = "The profile for passenger '"+pid+"' "+first+ " " + last + " '' was created.";
            db.insertPassengers(first, last);
        }

        private void addBookingBtn_Click(object sender, RoutedEventArgs e) {
            AddBooking window = new AddBooking(db);
            window.ShowDialog();

        }

        private void flightInstanceBtn_Click(object sender, RoutedEventArgs e) {
            try {
                //check
                if (!db.checkFlightInstance(flightInstanceComboBox.SelectedItem.ToString(), flightInstanceCal.SelectedDate.Value)) {
                    errorMsg.Content = "Flight Instance does not exist.";
                } else {
                    DataTable dt = db.getPassengers(flightInstanceComboBox.SelectedItem.ToString(), flightInstanceCal.SelectedDate.Value);
                    if (dt.Rows.Count == 0) {
                        errorMsg.Content = "This flight instance has no passengers.";
                    } else {
                        passengersDataGrid.DataContext = dt.DefaultView;
                        errorMsg.Content = "";
                        remainingSeatsLabel.Content = "Remaining Seats: " + db.getRemainingSeats(flightInstanceComboBox.SelectedValue.ToString(), flightInstanceCal.SelectedDate.Value);
                    }
                }
                //populate

                //remaining seats
            } catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

    }
}
