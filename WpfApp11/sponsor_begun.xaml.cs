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
    /// Логика взаимодействия для sponsor_begun.xaml
    /// </summary>
    public partial class sponsor_begun : Page
    {
        public sponsor_begun()
        {
            InitializeComponent();

            Binding bind = new Binding();
            bind.ElementName = "V";
            bind.Path = new PropertyPath("Text");

        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(t.Text))
            {
                t.Text = t.Tag.ToString();
            }
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == t.Tag.ToString())
            {
                t.Text = "";
            }
        }
        private void plus(object sender, RoutedEventArgs e)
        {
            double R = double.Parse(V.Text);
            if (R < 0 || R >= 100000)
            {
                R = 0;
            }
            R += 10;
            V.Text = $"{R}";
        }

        private void minus(object sender, RoutedEventArgs e)
        {
            double R = double.Parse(V.Text);
            if(R < 0 || R >= 100000)
            {
                R = 0;
            }
            if (R >= 10)
            {
                R -= 10;
            }
            V.Text = $"{R}";
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new start());
        }
        private void Pay(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new sponsor_pay(V.Text, us.Text));
        }
    }
}
