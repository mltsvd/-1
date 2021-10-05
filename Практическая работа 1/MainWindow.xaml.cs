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
using Lib_10;

namespace Практическая_работа_1
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
        
        private void Сброс_Click(object sender, RoutedEventArgs e)
        {
            Chisla.Text = null;
            Sum.Text = null;
            Kol.Text = null;
            K.Text = null;
        }

        private void Опрограмме_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Мельцаева Дарья\n"+"Практическая работа №1\n" + "Вычислить сумму целых случайных чисел, распределенных в диапазоне от 5 до 10, пока эта сумма не превышает некоторого числа K. Вывести на экран сгенерированные числа, значение суммы, и количество сгенерированных чисел.");
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Raschet_Click(object sender, RoutedEventArgs e)
        {
            int k,kol;
            k = Convert.ToInt32(K.Text);// ввод K
            Class1.Sum(k, out kol,out string s2, out string s1);// применение функции
            Chisla.Text = s2;// вывод сгенерированных чисел
            Sum.Text = s1;// вывод суммы
            Kol.Text = Convert.ToString(kol);// вывод количесва чисел
        }
    }
}
