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

namespace УМК_Цифра
{
    /// <summary>
    /// Логика взаимодействия для Bye.xaml
    /// </summary>
    public partial class Bye : Window
    {
        public Bye()
        {
            InitializeComponent();
            if (Manager.User != "root") 
            TxtScore.Text = $"Производство приобретенных знаний без Вас встало! Ваши баллы: {BDConnect.CurrentStudents.ScoreOtrasl}";
            else
            TxtScore.Text = "Производство приобретенных знаний без Вас встало! Вы не набрали баллы.";

        }
        private void myGif_MediaEnded(object sender, RoutedEventArgs e)
        {
            myGif.Position = new TimeSpan(0, 0, 1);
            myGif.Play();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Greetings greetings = new Greetings();
            greetings.Show();
            this.Close();
        }
    }
}
