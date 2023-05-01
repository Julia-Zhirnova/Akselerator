using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
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

namespace УМК_Цифра.Controls
{
    /// <summary>
    /// Логика взаимодействия для cmainpage.xaml
    /// </summary>
    public partial class cmainpage : Page
    {
        public cmainpage()
        {
            InitializeComponent();
        }

        private void Button_Click_Otrasl(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new c1Otrasl());
        }

        private void Button_Click_SIZ(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new c2SIZ());
        }

        private void Button_Click_Zone(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new c3Zone());
        }

        private void Button_Click_Shablon(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new c4Shablon());
        }

        private void Button_Click_Razmer(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new c5Razmer());
        }

        private void Button_Click_Zvet(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new c6Zvet());
        }

        private void Button_Click_Kachestvo(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new c7Kachestvo());
        }

        private void Button_Click_Kod(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new c8Kod());
        }
    }
}
