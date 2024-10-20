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

namespace lab4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task1_Click(object sender, RoutedEventArgs e)
        {
            Window wp1 = new Window1();
            wp1.Show();
        }

        private void Task2_Click(object sender, RoutedEventArgs e)
        {
            Window wp2 = new Window2();
            wp2.Show();
        }

        private void Task3_Click(object sender, RoutedEventArgs e)
        {
            Window wp3 = new Window3();
            wp3.Show();
        }

        private void Task4_Click(object sender, RoutedEventArgs e)
        {
            Window wp4 = new Window4();
            wp4.Show();
        }
    }
}
