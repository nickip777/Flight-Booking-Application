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
    /// Interaction logic for AddPassenger.xaml
    /// </summary>
    public partial class AddPassenger : Window {
        string firstName;
        string lastName;

        public AddPassenger() {
            InitializeComponent();
        }

        public string getFirstName() {
            return firstName;
        }

        public string getLastName() {
            return lastName;
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e) {
            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "") {
                errorLabel.Visibility = Visibility.Visible;
            } else {
                firstName = firstNameTextBox.Text;
                lastName = lastNameTextBox.Text;
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        

    }
}
