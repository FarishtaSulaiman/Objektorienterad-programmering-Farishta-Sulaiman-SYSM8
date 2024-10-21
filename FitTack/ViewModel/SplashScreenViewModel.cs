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
            // Kommando som körs när "Get Started"-knappen klickas
            public ICommand GetStartedCommand { get; }

            public SplashScreenViewModel()
            {
                // Skapa kommandot och binda det till metoden OpenMainWindow
                GetStartedCommand = new RelayCommand(OpenMainWindow);
            }

            private void OpenMainWindow(object parameter)
            {
                // Öppna huvudfönstret (MainWindow) och stäng splash screen
                var mainWindow = new View.MainWindow();
                mainWindow.Show();

                // Stäng SplashScreen (det första fönstret)
                Application.Current.Windows[0]?.Close();
            }
        }
    }