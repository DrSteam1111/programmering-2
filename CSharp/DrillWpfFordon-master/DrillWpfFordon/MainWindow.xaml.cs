using System.Collections.Generic;
using System.Windows;

namespace DrillWpfFordon
{ 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // lista med alla fordon
        private List<Vehicle> vehicles = new List<Vehicle>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(RegistrationNumber.Text))
                return;

            // skriv kod här för att spara fordon i lista
            vehicles.Add(new Vehicle(RegistrationNumber.Text));

            int lastIndex = vehicles.Count - 1;
            if (!string.IsNullOrEmpty(Owner.Text))
                vehicles[lastIndex].CarOwner = Owner.Text;

            vehicles.Sort();

            Vehicles.Text = "Visa alla fordon här. ";
            for (int i = 0; i < vehicles.Count; i++)
            {
                Vehicles.Text += vehicles[i].ToString();
            }
        }
    }
}
