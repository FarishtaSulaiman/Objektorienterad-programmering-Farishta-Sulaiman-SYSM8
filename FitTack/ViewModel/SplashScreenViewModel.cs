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

        public ICommand GetStartedCommand { get; }

        public SplashScreenViewModel(IWindowFactory windowFactory)
        {
            _windowFactory = windowFactory;
            GetStartedCommand = new RelayCommand(OpenMainWindow);
        }

        private void OpenMainWindow(object parameter)
        {
            // Öppna MainWindow via WindowFactory
            _windowFactory.ShowMainWindow();
            // Stänga SplashScreen (det görs via WindowFactory i SplashScreen.xaml.cs)
        }
    }
}