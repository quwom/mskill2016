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
    /// Логика взаимодействия для start.xaml
    /// </summary>
    public partial class start : Page
    {
        public start()
        {
            InitializeComponent();
        }



        private void a_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new new_speed());
        }
        private void b_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new sponsor_begun());
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new reg_begun());
        }

    }
}
