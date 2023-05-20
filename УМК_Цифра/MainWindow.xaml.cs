using System.Windows;

namespace УМК_Цифра
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }        
        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            Greetings greetings = new Greetings();
            greetings.Show();
            this.Close();
        }        
    }
}
