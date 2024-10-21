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
    public class MainWindowViewModel : ViewModelBase
    {
        // Egenskaper för användarnamn och lösenord
        public string Username { get; set; }
        public string Password { get; set; }

        // Kommandon för knapparna
        public ICommand SignInCommand { get; }
        public ICommand ForgotPasswordCommand { get; }
        public ICommand RegisterCommand { get; }
        public RegisterWindowViewModel DataContext { get; private set; }

        public MainWindowViewModel()
        {
            // Initialisera kommandon och koppla dem till funktionerna
            SignInCommand = new RelayCommand(SignIn);
            ForgotPasswordCommand = new RelayCommand(ForgotPassword);
            RegisterCommand = new RelayCommand(Register);
        }

        // Logik för Sign In-knappen
        private void SignIn(object parameter)
        {
            if (Username == "admin" && Password == "Admin321!")
            {
                MessageBox.Show("Inloggning lyckades!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Fel användarnamn eller lösenord.", "Fel", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            var viewModel = DataContext as ViewModel.RegisterWindowViewModel;
            if (viewModel != null)
            {
                MessageBox.Show("hejhej");
                
                //  viewModel.PasswordBox_PasswordChanged /// kolla och gör rätt" 
            }
        }

        // Logik för Forgot Password-knappen
        private void ForgotPassword(object parameter)
        {
            if (string.IsNullOrEmpty(Username))
            {
                MessageBox.Show("Ange ditt användarnamn för att återställa lösenord.", "Fel", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Username == "admin")
            {
                string securityQuestion = "Vad är ditt favoritdjur?";
                string correctAnswer = "hund";

                string answer = Microsoft.VisualBasic.Interaction.InputBox(securityQuestion, "Säkerhetsfråga");

                if (answer.ToLower() == correctAnswer.ToLower())
                {
                    MessageBox.Show("Lösenordet har återställts till 'admin123'.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Fel svar på säkerhetsfrågan.", "Fel", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Användarnamnet existerar inte.", "Fel", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Logik för Register-knappen
        private void Register(object parameter)
        {
            // RegisterWindow öppnas
            var registerWindow = new View.RegisterWindow();
            registerWindow.Show();
            Application.Current.Windows[0]?.Close(); // stänga Mainwindow

            
        }
    }
}