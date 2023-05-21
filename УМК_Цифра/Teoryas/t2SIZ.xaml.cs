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
    /// Логика взаимодействия для tSIZ.xaml
    /// </summary>
    public partial class t2SIZ : Page
    {
        public t2SIZ()
        {
            InitializeComponent();
            cb1.ItemsSource = new List<string>() { "Выбрать ответ", "Текст", "Изображение", "Аудио" };
            cb1.SelectedIndex = 0;
            if (Manager.User == "root") r1.IsEnabled = false;
            else if (BDConnect.CurrentStudents.ScoreOtrasl >= 1) r1.IsEnabled = false;
            else r1.IsEnabled = true;
        }
        private void Rezult(object sender, RoutedEventArgs e)
        {
            if (cb1.SelectedIndex == 2)
            {
                if (BDConnect.CurrentStudents.ScoreOtrasl > 0)
                    BDConnect.CurrentStudents.ScoreOtrasl = BDConnect.CurrentStudents.ScoreOtrasl + 1;
                else BDConnect.CurrentStudents.ScoreOtrasl = 1;
                try
                {
                    BDConnect.modelOdb.SaveChanges();
                    MessageBox.Show("Отлично, Вы получили балл", "Так держать!",
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
