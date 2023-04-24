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

namespace ZAD3
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
        private double TriangleP(double a, double h)
        {
            double b = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(h, 2)); // находим боковую сторону
            double p = 2 * b + a; // находим периметр
            return p;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double a, h;
            if (double.TryParse(tbA.Text, out a) && double.TryParse(tbH.Text, out h))
            {
                double p = TriangleP(a, h);
                lbResults.Items.Add(string.Format("Основание: {0}, Высота: {1}, Периметр: {2}", a, h, p));
            }
            else
            {
                MessageBox.Show("Некорректные входные данные");
            }
        }
    }
}
