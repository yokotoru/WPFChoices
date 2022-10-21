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

namespace Choices
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private static bool closing;
        public Login()
        {
            InitializeComponent();
            closing = true;
        }

        private void registrationClick(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            closing = false;
            Close();
        }

        private void loginClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            closing = false;
            Close();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (closing)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
