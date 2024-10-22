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
        public ICommand GetStartedCommand { get; }

        public SplashScreenViewModel()
        {
            GetStartedCommand = new RelayCommand(OpenMainWindow);
        }

        private void OpenMainWindow(object parameter)
        {
            // Öppna MainWindow och stäng SplashScreen
            var mainWindow = new MainWindow();
            mainWindow.Show();

            // Stäng nuvarande fönster (SplashScreen)
            Application.Current.MainWindow?.Close();
        }
    }
}