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
        private readonly IWindowFactory _windowFactory;
        private readonly Window _splashScreenWindow;

        public ICommand GetStartedCommand { get; }

        public SplashScreenViewModel(IWindowFactory windowFactory, Window splashScreenWindow)
        {
            _windowFactory = windowFactory;
            _splashScreenWindow = splashScreenWindow;
            GetStartedCommand = new RelayCommand(OpenMainWindow);
        }

        private void OpenMainWindow(object parameter)
        {
            _windowFactory.ShowMainWindow();  // Visa MainWindow
            _splashScreenWindow.Close();      // Stäng SplashScreen
        }
    }
}