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

namespace УМК_Цифра.Teoryas
{
    /// <summary>
    /// Логика взаимодействия для tKod.xaml
    /// </summary>
    public partial class t8Kod : Page
    {
        public t8Kod()
        {
            InitializeComponent();
        }
        private void Proiz1(object sender, RoutedEventArgs e)
        {
            Score.ScorePoint -= 1;
            MessageBox.Show("Неверно, Вы потеряли балл");
        }
        private void Proiz2(object sender, RoutedEventArgs e)
        {
            Score.ScorePoint += 1;
            MessageBox.Show("Верно, Вы получили балл");

        }
        private void Proiz3(object sender, RoutedEventArgs e)
        {
            Score.ScorePoint -= 1;
            MessageBox.Show("Неверно, Вы потеряли балл");
        }

        private void myGif_MediaEnded(object sender, RoutedEventArgs e)
        {
            myGif.Position = new TimeSpan(0, 0, 1);
            myGif.Play();
        }
    }
}
