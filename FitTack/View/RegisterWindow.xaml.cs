using FitTack.MVVM;
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
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public class RegisterWindowViewModel : ViewModelBase
    {
        private readonly IWindowFactory _windowFactory;

        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand RegisterCommand { get; }
        public ICommand CancelCommand { get; }

        public RegisterWindowViewModel(IWindowFactory windowFactory)
        {
            _windowFactory = windowFactory;

            // Initialisera kommandon
            RegisterCommand = new RelayCommand(RegisterUser);
            CancelCommand = new RelayCommand(CancelRegistration);
        }

        private void RegisterUser(object parameter)
        {
            // Enkel validering och registreringslogik
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Fyll i alla fält.", "Fel", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Här kan du lägga till logik för att spara användaren i din lista eller databas

            MessageBox.Show("Användaren har registrerats!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

            // Efter framgångsrik registrering, stäng RegisterWindow och öppna MainWindow
            _windowFactory.CloseWindow(); // Stäng RegisterWindow
            _windowFactory.ShowMainWindow(); // Öppna MainWindow
        }

        private void CancelRegistration(object parameter)
        {
            // Om användaren avbryter, stäng RegisterWindow och öppna MainWindow
            _windowFactory.CloseWindow();
            _windowFactory.ShowMainWindow();
        }
    }
}