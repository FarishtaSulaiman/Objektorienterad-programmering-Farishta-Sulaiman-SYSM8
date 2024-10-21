using FitTack.ViewModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace FitTack
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        {
            protected override void OnStartup(StartupEventArgs e)
            {
                base.OnStartup(e);

                // Skapa en instans av WindowFactory
                var windowFactory = new WindowFactory();

                // Skapa MainWindowViewModel och injicera windowFactory
                var mainWindowViewModel = new MainWindowViewModel(windowFactory);

                // Skapa och visa MainWindow
                var mainWindow = new MainWindow
                {
                    DataContext = mainWindowViewModel
                };

                mainWindow.Show();
            }
        }
    }

