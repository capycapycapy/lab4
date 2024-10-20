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

namespace lab4
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void SumButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = int.Parse(txtA.Text);
                int B = int.Parse(txtB.Text);

                if (A >= B)
                {
                    txtResult.Text = "Дорогой пользователь, A должно быть меньше B.";
                    return;
                }

                int sum = 0;
                for (int i = A + 1; i < B; i++)
                {
                    sum += i;
                }

                txtResult.Text = $"Сумма чисел между {A} и {B} = {sum}";
            }
            catch (FormatException)
            {
                txtResult.Text = "Пользователь, введите корректные целые числа.";
            }
        }

        private void OddNumbersButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = int.Parse(txtA.Text);
                int B = int.Parse(txtB.Text);

                if (A >= B)
                {
                    txtResult.Text = "Дорогой пользователь, A должно быть меньше B.";
                    return;
                }

                var oddNumbers = Enumerable.Range(A + 1, B - A - 1).Where(n => n % 2 != 0).ToList();

                if (oddNumbers.Count > 0)
                {
                    txtResult.Text = $"Нечетные числа между {A} и {B}: {string.Join(", ", oddNumbers)}";
                }
                else
                {
                    txtResult.Text = $"Между {A} и {B} нет нечетных чисел.";
                }
            }
            catch (FormatException)
            {
                txtResult.Text = "Пользователь, введите корректные целые числа.";
            }
        }
    }
}
