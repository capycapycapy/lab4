//nn
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

    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void ShowSquares_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 10; i <= 20; i++)
            {
                int square = i * i;
                result.AppendLine($"Квадрат числа {i} = {square}");
            }

            txtResult.Text = result.ToString(); 
        }
    }
}

