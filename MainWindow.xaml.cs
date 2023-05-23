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


namespace practika2
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
            if (int.TryParse(textBoxA.Text, out int a) && int.TryParse(textBoxB.Text, out int b))
            {
                if (a > b)
                {
                    int Result = a / b;
                    textBoxOtvet.Text = Result.ToString();
                }
                else
                {
                    textBoxOtvet.Text = "Число A должно быть больше числа B";
                }
            }
            else
            {
                textBoxOtvet.Text = "Ошибка ввода";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(textBoxN.Text);

            int seconds = n % 3600;

            textBoxOtvet1.Text = "Прошло секунд с начала последнего часа: " + seconds;
        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(textBoxK.Text, out int K))
            {
                int k = int.Parse(textBoxK.Text);

                int dayOfWeek = (k + 5) % 7 + 1;
                textBoxOtvet2.Text = dayOfWeek.ToString();
            }
            else
            {
                textBoxOtvet2.Text = "Ошибка ввода";
            }
        }






    }
}