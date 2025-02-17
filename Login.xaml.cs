using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace UCD
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (FieldComboBox.SelectedItem is ComboBoxItem selectedField && SemesterComboBox.SelectedItem is ComboBoxItem selectedSemester)
            {
                string chosenField = selectedField.Content.ToString();
                string chosenSemester = selectedSemester.Content.ToString();

                // Fade Out Animation
                DoubleAnimation fadeOut = new DoubleAnimation(0, TimeSpan.FromSeconds(0.3));
                fadeOut.Completed += (s, a) =>
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                };
                this.BeginAnimation(OpacityProperty, fadeOut);
            }
            else
            {
                MessageBox.Show("Please select both a field and a semester!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
