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
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        private void CalculateSum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(txtN.Text);

                if (n < 1)
                {
                    txtResult.Text = "Пользователь, n должно быть больше или равно 1.";
                    return;
                }

                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }

                txtResult.Text = $"Сумма чисел от 1 до {n} = {sum}";
            }
            catch (FormatException)
            {
                txtResult.Text = "Пользователь, введите корректное целое число.";
            }
        }
    }
}

