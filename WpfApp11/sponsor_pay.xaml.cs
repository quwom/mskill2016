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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp11
{
    /// <summary>
    /// Логика взаимодействия для sponsor_pay.xaml
    /// </summary>
    public partial class sponsor_pay : Page
    {
        public sponsor_pay(string r, string user)
        {
            InitializeComponent();
            User.Text = user;
            Money.Text = r;
        }

        private void Nazad(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new start());
        }
    }
}
