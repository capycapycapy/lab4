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
    public partial class Window4 : Window
    { public Window4()
        {
            InitializeComponent();
        }
        private void CalculateBonus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double salary = double.Parse(txtSalary.Text);
                int years = int.Parse(txtYears.Text);
                if (salary <= 0 || years < 0)
                {
                    txtResult.Text = "Пользователь, введите корректные данные.";
                    return;
                }
                double bonusPercentage = 0;
                if (years < 5)
                {
                    bonusPercentage = 0.10;
                }
                else if (years < 10)
                {
                    bonusPercentage = 0.15;
                }
                else if (years < 15)
                {
                    bonusPercentage = 0.25;
                }
                else if (years < 20)
                {
                    bonusPercentage = 0.35;
                }
                else if (years < 25)
                {
                    bonusPercentage = 0.45;
                }
                else
                {
                    bonusPercentage = 0.50;
                }
                double bonus = salary * bonusPercentage;
                txtResult.Text = $"Премия составляет: {bonusPercentage * 100}% от зарплаты.\nПремия:  {bonus:F2} руб.";
            }
            catch (FormatException)
            {
                txtResult.Text = "Пользователь, введите корректные числовые значения.";
            }
        }
    }
}
