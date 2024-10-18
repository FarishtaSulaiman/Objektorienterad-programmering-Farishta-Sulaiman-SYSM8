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

namespace FitTack.View
{
    /// <summary>
    /// Interaction logic for SplayScreen.xaml
    /// </summary>
    public partial class SplayScreen : Window
    {
        public SplayScreen()
        {
            InitializeComponent();
        }
        // Hantera "Get Started"-knappens 
        private void GetStarted_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Stäng SplashScreen
        }
    }
}
    

