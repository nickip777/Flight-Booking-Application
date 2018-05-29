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

namespace cmpt300a7 {
    /// <summary>
    /// Interaction logic for AddBooking.xaml
    /// </summary>
    public partial class AddBooking : Window {
        private sqlDB db;
        public AddBooking(sqlDB database) {
            InitializeComponent();
            this.db = database;
            pidComboBox.ItemsSource = db.getPids();
            leaveFlightComboBox.ItemsSource = db.getFlightCodes();
            returningFlightComboBox.ItemsSource = db.getFlightCodes();
        }


        private bool checkCalDays() {
            if (System.DateTime.Compare(leavingCal.SelectedDate.Value, returningCal.SelectedDate.Value) > 0) {
                errorMsg.Content = "Second flight date earlier than first flight date.";
                return false;
            } else {
                return true;
            }
        }

        private bool checkLeavingFlightCode() {
            if (singleWayRadio.IsChecked == true) {
                if (leaveFlightComboBox.Text == "") {
                    errorMsg.Content = "Flight Code not selected.";
                    return false;
                } else {
                    return true;
                }
            } else {
                if (leaveFlightComboBox.Text == "" || returningFlightComboBox.Text == "") {
                    errorMsg.Content = "Flight Code not selected.";
                    return false;
                } else {
                    return true;
                }
            }
        }

        private bool checkPid() {
            if (pidComboBox.Text == "") {
                errorMsg.Content = "Passenger ID not selected.";
                return false;
            } else {
                return true;
            }
        }
        private void singleHide() {
            returnFlightCodeLabel.Visibility = Visibility.Hidden;
            returningCal.Visibility = Visibility.Hidden;
            returningFlightComboBox.Visibility = Visibility.Hidden;
            returnLabel.Visibility = Visibility.Hidden;
        }

        private void multiShow() {
            returnFlightCodeLabel.Visibility = Visibility.Visible;
            returningCal.Visibility = Visibility.Visible;
            returningFlightComboBox.Visibility = Visibility.Visible;
            returnLabel.Visibility = Visibility.Visible;
        }

        private void multiWayRadio_Click(object sender, RoutedEventArgs e) {
            multiWayRadio.IsChecked = true;
            singleWayRadio.IsChecked = false;
            multiShow();
        }

        private void singleWayRadio_Click(object sender, RoutedEventArgs e) {
            singleWayRadio.IsChecked = true;
            multiWayRadio.IsChecked = false;
            singleHide();
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e) {
            //check
            string arr = "arr";
            string dep = "dep";
            if(!leavingAirports.Content.Equals("") && !returningAirports.Content.Equals("")){
                arr = leavingAirports.Content.ToString().Substring(leavingAirports.Content.ToString().Length - 3);
                dep = returningAirports.Content.ToString().Substring(0,3);
            }
            if (multiWayRadio.IsChecked == true) {
                if (pidComboBox.SelectedValue == "" || leavingCal.SelectedDate == null || leaveFlightComboBox.SelectedValue == "" || returningFlightComboBox.SelectedValue == "" || returningCal.SelectedDate == null) {
                    errorMsg.Content = "All fields must be selected.";
                }else if (!db.checkFlightInstance(leaveFlightComboBox.SelectedValue.ToString(), leavingCal.SelectedDate.Value)){
                    errorMsg.Content = "First flight does not exist.";
                } else if (!db.checkFlightInstance(returningFlightComboBox.SelectedValue.ToString(), returningCal.SelectedDate.Value)) {
                    errorMsg.Content = "Second flight does not exist.";
                } else if (!db.checkEmptySpace(leaveFlightComboBox.SelectedValue.ToString(), leavingCal.SelectedDate.Value)) {
                        errorMsg.Content = "No empty space on first flight.";
                } else if (!db.checkEmptySpace(returningFlightComboBox.SelectedValue.ToString(), returningCal.SelectedDate.Value)) {
                    errorMsg.Content = "No empty space on second flight.";
                }else if(!arr.Equals(dep)){
                    errorMsg.Content = "Arrival airport of first flight must be the same as the departure flight of the second flight.";
                }else if (checkCalDays()) {
                    db.insertBookings(leaveFlightComboBox.SelectedValue.ToString(), leavingCal.SelectedDate.Value, pidComboBox.SelectedValue.ToString());
                    db.insertBookings(returningFlightComboBox.SelectedValue.ToString(), returningCal.SelectedDate.Value, pidComboBox.SelectedValue.ToString());
                    this.Close();
                }
            } else {
                if (pidComboBox.SelectedValue == "" || leavingCal.SelectedDate == null || leaveFlightComboBox.SelectedValue == "") {
                    errorMsg.Content = "All fields must be selected.";
                } else if (!db.checkFlightInstance(leaveFlightComboBox.SelectedValue.ToString(), leavingCal.SelectedDate.Value)) {
                    errorMsg.Content = "Flight does not exist.";
                } else if (!db.checkEmptySpace(leaveFlightComboBox.SelectedValue.ToString(), leavingCal.SelectedDate.Value)) {
                    errorMsg.Content = "No empty space on flight.";
                } else {
                    db.insertBookings(leaveFlightComboBox.SelectedValue.ToString(), leavingCal.SelectedDate.Value, pidComboBox.SelectedValue.ToString());
                    this.Close();
                }
            }
            
        }

        
        private void leaveFlightComboBoxEvent(object sender, SelectionChangedEventArgs e) {
            if (leaveFlightComboBox.SelectedItem != null) {
                leavingAirports.Content = db.getAirports(leaveFlightComboBox.SelectedValue.ToString());
            }
        }

        private void returningFlightComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (returningFlightComboBox.SelectedItem != null) {
                returningAirports.Content = db.getAirports(returningFlightComboBox.SelectedValue.ToString());
            }
        }
    }
}
