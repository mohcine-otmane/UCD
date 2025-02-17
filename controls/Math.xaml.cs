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
    /// Interaction logic for Math.xaml
    /// </summary>
    public partial class Math : UserControl
    {
        public Math()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = Window.GetWindow(this);
            if (mainWindow != null)
            {
                StackPanel transform = mainWindow.FindName("MainPanel") as StackPanel;
                if (transform != null)
                {
                    transform.Margin = new Thickness(0, 0, 0, 0);
                }
            }
        }
    }
}
