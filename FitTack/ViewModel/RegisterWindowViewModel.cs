using FitTack.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace FitTack.ViewModel
{
    public class RegisterWindowViewModel
    {

        // Egenskaper
        public string Username { get; set; }
        private string Password { get; set; }
        private string ConfirmPassword { get; set; }
        public ObservableCollection<string> Countries { get; set; }
        public string SelectedCountry { get; set; }

        // Kommando för att registrera användaren
        public ICommand RegisterCommand { get; }

        public RegisterWindowViewModel()
        {
            // Fyller ComboBox med länder som jag valt 
            Countries = ["Sverige", "Norge", "Finland", "Danmark"];

            // Initialisering av kommando
            RegisterCommand = new RelayCommand(Register);
        }

        // Hanterar lösenord-input från PasswordBox
        public void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = sender as PasswordBox;
            Password = passwordBox.Password;
        }

        // Hanterar bekräftelse-lösenord från ConfirmPasswordBox
        public void ConfirmPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = sender as PasswordBox;
            ConfirmPassword = passwordBox.Password;
        }

        // Validerar lösenord
        private bool IsValidPassword(string password)
        {
            // Lösenordet måste vara minst 8 tecken långt, ha en siffra och ett specialtecken
            var passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$";
            return Regex.IsMatch(password, passwordPattern);
        }

        // Hanterar registrering
        private void Register(object parameter)
        {
            // Kontrollera om användarnamnet redan är upptaget 
            if (Username == "admin") // Simulerar upptaget användarnamn
            {
                MessageBox.Show("Användarnamnet är redan upptaget!", "Fel", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Kontrollera om lösenordet matchar och är giltigt
            if (Password != ConfirmPassword)
            {
                MessageBox.Show("Lösenorden matchar inte!", "Fel", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!IsValidPassword(Password))
            {
                MessageBox.Show("Lösenordet måste vara minst 8 tecken långt och innehålla minst en siffra och ett specialtecken.", "Fel", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Användaren har registrerats 
            MessageBox.Show($"Användaren {Username} har registrerats framgångsrikt!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

            // Stäng registerfönstret 
            Application.Current.Windows[0]?.Close();

            // Öppna ett nytt MainWindow 
            var mainWindow = new View.MainWindow();
            mainWindow.Show();
        }
    }
}
    

