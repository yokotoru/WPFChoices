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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        private static bool closing;
        public Registration()
        {
            InitializeComponent();
            closing = true;
        }

        private void registrationClick(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            closing = false;
            Close();
        }

        private void backClick(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
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
