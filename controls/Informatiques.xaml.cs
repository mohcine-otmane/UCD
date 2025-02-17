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

namespace UCD.controls
{
    /// <summary>
    /// Interaction logic for Informatiques.xaml
    /// </summary>
    public partial class Informatiques : UserControl
    {
        public Informatiques()
        {
            InitializeComponent();
        }


        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = Window.GetWindow(this);
            if (mainWindow != null)
            {
                TranslateTransform transform = mainWindow.FindName("MainPanelTransform") as TranslateTransform;
                if (transform != null)
                {
                    transform.X = 0; // Moves the panel back to the first section
                }
            }
        }


    }
}
