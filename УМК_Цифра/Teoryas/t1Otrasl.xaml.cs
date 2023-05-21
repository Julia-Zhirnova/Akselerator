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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace УМК_Цифра.Teoryas
{
    /// <summary>
    /// Логика взаимодействия для tOtrasl.xaml
    /// </summary>
    public partial class t1Otrasl : Page
    {
        public t1Otrasl()
        {
            InitializeComponent();
            cb1.ItemsSource = new List<string>() { "Выбрать ответ", "Tom", "Bob", "Sam" };
            cb1.SelectedIndex = 0;
            if (Manager.User == "root" || BDConnect.CurrentStudents.ScoreOtrasl > 1) r1.IsEnabled = false;
            else r1.IsEnabled = true;
        }
       
        private void Proiz1(object sender, RoutedEventArgs e)
        {
            if (BDConnect.CurrentStudents.ScoreOtrasl > 0)
            BDConnect.CurrentStudents.ScoreOtrasl = BDConnect.CurrentStudents.ScoreOtrasl - 1;
            MessageBox.Show("Неверно, Вы потеряли балл", "Попробуйте снова",
                            MessageBoxButton.OK, MessageBoxImage.Warning);  
        }
        private void Proiz2(object sender, RoutedEventArgs e)
        {            
            
            BDConnect.CurrentStudents.ScoreOtrasl = 1;
            try
            {
                BDConnect.modelOdb.SaveChanges();
                MessageBox.Show(BDConnect.CurrentStudents.ScoreOtrasl.ToString(), "Так держать!",
                            MessageBoxButton.OK, MessageBoxImage.Information);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
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

        private void Rezult(object sender, RoutedEventArgs e)
        {            
            if (cb1.SelectedIndex == 2)
            {
                if(BDConnect.CurrentStudents.ScoreOtrasl > 0)
                BDConnect.CurrentStudents.ScoreOtrasl = BDConnect.CurrentStudents.ScoreOtrasl + 1;
                else BDConnect.CurrentStudents.ScoreOtrasl = 1;
                try
                {
                    BDConnect.modelOdb.SaveChanges();
                    MessageBox.Show(BDConnect.CurrentStudents.ScoreOtrasl.ToString(), "Так держать!",
                                MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                if (BDConnect.CurrentStudents.ScoreOtrasl > 0) 
                BDConnect.CurrentStudents.ScoreOtrasl = BDConnect.CurrentStudents.ScoreOtrasl - 1;
                try
                {
                    BDConnect.modelOdb.SaveChanges();
                    MessageBox.Show("Неверно, Вы потеряли балл", "Попробуйте снова",
                            MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            r1.IsEnabled = false;
        }
    }
   
}
