using FitTack.ViewModel;
using System.Configuration;
using System.Data;
using System.Windows;
using FitTack.View;
namespace FitTack
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Skapa och visa SplashScreen
            var splashScreen = new View.SplashScreen();
            splashScreen.Show();
        }
    }
}