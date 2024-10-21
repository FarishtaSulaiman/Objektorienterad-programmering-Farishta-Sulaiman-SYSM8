using FitTack.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FitTack.ViewModel
{
    public class SplashScreenViewModel : ViewModelBase
    {


        // Kommandot som körs när "Get Started"-knappen klickas
        public ICommand GetStartedCommand { get; }

        public SplashScreenViewModel()
        {
            GetStartedCommand = new RelayCommand(OpenMainWindow);
        }

        private void OpenMainWindow(object parameter)
        {
            // Logik för att öppna MainWindow och stänga SplashScreen
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            // Stäng fönstret SplashScreen
            Application.Current.Windows[0].Close();
        }
    }
}
