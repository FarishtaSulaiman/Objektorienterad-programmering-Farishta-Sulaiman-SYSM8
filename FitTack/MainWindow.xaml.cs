using FitTack.View;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FitTack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // Inloggningslogik
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameInput.Text;
            string password = PasswordInput.Password;

            // Enkel validering för exempel
            if (username == "admin" && password == "admin123") // Simulera inloggning
            {
                MessageBox.Show("Inloggning lyckades!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                // Öppna huvudfönstret för användaren eller träningsfönster
            }
            else
            {
                MessageBox.Show("Fel användarnamn eller lösenord.", "Fel", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }




        // Hantera "Glömt lösenord"
        private void ForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameInput.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Ange ditt användarnamn för att återställa lösenord.", "Fel", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // återställning av lösenord
            if (username == "admin") // Exempel
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

        // Öppna registreringsfönstret
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            this.Close(); // Stäng MainWindow
        }
    }
}
    
