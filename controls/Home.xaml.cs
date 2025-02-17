using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UCD.controls
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        

        private void Button_Click_Math(object sender, RoutedEventArgs e)
        {
            Window mainWindow = Window.GetWindow(this);

            if (mainWindow != null)
            {
                StackPanel transform = mainWindow.FindName("MainPanel") as StackPanel;
                if (transform != null)
                {
                    transform.Margin = new Thickness(-800, 0, 0, 0);
                }
            }
        }

        private void Button_Click_Info(object sender, RoutedEventArgs e)
        {
            Window mainWindow = Window.GetWindow(this);

            if (mainWindow != null)
            {
                StackPanel transform = mainWindow.FindName("MainPanel") as StackPanel;
                if (transform != null)
                {
                    transform.Margin = new Thickness(-1600, 0, 0, 0);
                }
            }
        }

        private void Button_Click_Physique(object sender, RoutedEventArgs e)
        {
            Window mainWindow = Window.GetWindow(this);

            if (mainWindow != null)
            {
                StackPanel transform = mainWindow.FindName("MainPanel") as StackPanel;
                if (transform != null)
                {
                    transform.Margin = new Thickness(-2400, 0, 0, 0);
                }
            }
        }

    }
}
