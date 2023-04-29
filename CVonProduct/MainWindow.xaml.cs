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
using Telerik.Windows.Controls;

namespace CVonProduct
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);
            StyleManager.ApplicationTheme = new TransparentTheme();
        }
        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            /*Menu menu = new Menu();
            menu.Show();*/
            Greetings greetings = new Greetings();
            greetings.Show();
        }
        private void Button_Enter(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
