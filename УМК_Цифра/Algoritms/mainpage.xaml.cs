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
using УМК_Цифра.Controls;

namespace УМК_Цифра.Algoritms
{
    /// <summary>
    /// Логика взаимодействия для mainpage.xaml
    /// </summary>
    public partial class mainpage : Page
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void Button_Click_Otrasl(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new a1Otrasl());
        }

        private void Button_Click_SIZ(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new a2SIZ());
        }

        private void Button_Click_Zone(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new a3Zone());
        }

        private void Button_Click_Shablon(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new a4Shablon());
        }

        private void Button_Click_Razmer(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new a5Razmer());
        }

        private void Button_Click_Zvet(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new a6Zvet());
        }

        private void Button_Click_Kachestvo(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new a7Kachestvo());
        }

        private void Button_Click_Kod(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new a8Kod());
        }
    }
}
