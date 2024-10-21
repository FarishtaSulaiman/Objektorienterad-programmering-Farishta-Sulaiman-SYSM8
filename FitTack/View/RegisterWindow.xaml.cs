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
    public partial class RegisterWindow : Window
        {
            public RegisterWindow()
            {
                InitializeComponent();
            ViewModel.RegisterWindowViewModel registerWindowViewModel = new ViewModel.RegisterWindowViewModel();
                DataContext = registerWindowViewModel;
            }

            // Hantera lösenordsinmatning
            private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
            {
                var viewModel = DataContext as ViewModel.RegisterWindowViewModel;
                if (viewModel != null)
                {
                    viewModel.PasswordBox_PasswordChanged(sender, e);
                }
            }

            // Hantera bekräftelse-lösenordsinmatning
            private void ConfirmPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
            {
            if (DataContext is ViewModel.RegisterWindowViewModel viewModel)
            {
                viewModel.ConfirmPasswordBox_PasswordChanged(sender, e);
            }
        }
        }
    }
