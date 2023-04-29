using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CVonProduct
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);
        }
        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Bye bye = new Bye();
            bye.Show();
        }
        private void Button_Click_Teorya(object sender, RoutedEventArgs e)
        {
            NavigarionPanel teorya = new NavigarionPanel();
            teorya.Owner = this;
            teorya.Show();
            // this.Close();
        }

        private void Button_Click_Algoritm(object sender, RoutedEventArgs e)
        {
            NavigarionPanel algoritm = new NavigarionPanel();
            algoritm.Owner = this;
            algoritm.Show();
        }

        private void Button_Click_Result(object sender, RoutedEventArgs e)
        {
            NavigarionPanel result = new NavigarionPanel();
            result.Owner = this;
            result.Show();
        }

        private void Button_Click_Control(object sender, RoutedEventArgs e)
        {
            NavigarionPanel control = new NavigarionPanel();
            control.Owner = this;
            control.Show();
        }
    }
}
