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
    /// Логика взаимодействия для begun_menu.xaml
    /// </summary>
    /// Hilpy Corporation ooo mmm make
    public partial class begun_menu : Page
    {
        public begun_menu()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new sponsor());
        }

        private void Mess_Click(object sender, RoutedEventArgs e)
        {
            new contacts().Show();
        }
        private void Spon_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new my_sponsors());
        }

    }
}
