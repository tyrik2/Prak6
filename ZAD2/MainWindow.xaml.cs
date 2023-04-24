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

namespace ZAD2
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
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // проверяем, что пользователь ввел корректные данные
            if (!double.TryParse(txtX.Text, out double x) || !int.TryParse(txtN.Text, out int n))
            {
                lblErrorMessage.Content = "Неверный ввод";
                return;
            }

            // проверяем, что n больше 0
            if (n <= 0)
            {
                lblErrorMessage.Content = "n должно быть положительным";
                return;
            }

            // вычисляем значение выражения
            double sum = 0;
            for (int i = 2; i <= 6; i += 2)
            {
                sum += f(i, x);
            }

            // выводим результат
            txtResult.Text = sum.ToString();
            txtError.Text = "";
            lblErrorMessage.Content = "";
        }

        private double f(int n, double x)
        {
            return Math.Pow(x, n) / n;
        }
    }
}
