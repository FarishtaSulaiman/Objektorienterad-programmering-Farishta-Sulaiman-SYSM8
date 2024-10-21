using FitTack.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FitTack
{
    public class WindowFactory : IWindowFactory
    {
        // Öppna MainWindow
        public void ShowMainWindow()
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }

        // Öppna RegisterWindow
        public void ShowRegisterWindow()
        {
            var registerWindow = new RegisterWindow();
            registerWindow.Show();
        }

        // Stäng nuvarande fönster
        public void CloseWindow()
        {
            // Stänger det aktuella öppna fönstret
            Application.Current.Windows[0]?.Close();
        }
    }
}

