using FitTack.View;
using FitTack.ViewModel;
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
                DataContext = new MainWindowViewModel();
            }

            // Event för PasswordBox när lösenordet ändras
            private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
            {
                // Använd ett annat namn för variabeln, t.ex. "pwdBox"
                PasswordBox? pwdBox = sender as PasswordBox;

                // Kontrollerar att DataContext är satt korrekt till ViewModel
                var viewModel = this.DataContext as MainWindowViewModel;
                if (viewModel != null)
                {
                    // Uppdaterar lösenordet i ViewModel
                    viewModel.Password = pwdBox.Password;
                }
            }

            // Inloggningslogik (för Sign In-knappen)
            private void SignIn_Click(object sender, RoutedEventArgs e)
            {
                var viewModel = this.DataContext as MainWindowViewModel;
                string username = viewModel.Username;
                string password = viewModel.Password;

                if (username == "admin" && password == "admin123")
                {
                    MessageBox.Show("Inloggning lyckades!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Fel användarnamn eller lösenord.", "Fel", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            // Hantera "Glömt lösenord"
            private void ForgotPassword_Click(object sender, RoutedEventArgs e)
            {
                var viewModel = this.DataContext as MainWindowViewModel;
                string username = viewModel.Username;

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Ange ditt användarnamn för att återställa lösenord.", "Fel", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (username == "admin")
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

