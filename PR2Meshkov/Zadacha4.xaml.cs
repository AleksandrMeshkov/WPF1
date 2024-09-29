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

namespace PR2Meshkov
{
    /// <summary>
    /// Логика взаимодействия для Zadacha4.xaml
    /// </summary>
    public partial class Zadacha4 : Window
    {
        public Zadacha4()
        {
            InitializeComponent();
            CenterWindow();
        }

        private void CenterWindow()
        {
            double screenWidth = SystemParameters.PrimaryScreenWidth;
            double screenHeight = SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTextBox.Text;
            int[] numbers = input.Split(',')
                                 .Select(s => int.TryParse(s.Trim(), out int n) ? n : 0)
                                 .ToArray();

            // Поиск первого простого и первого совершенного числа
            int primeIndex = -1;
            int perfectIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsPrime(numbers[i]) && primeIndex == -1)
                {
                    primeIndex = i; // Запоминаем индекс первого простого числа
                }
                if (IsPerfect(numbers[i]) && perfectIndex == -1)
                {
                    perfectIndex = i; // Запоминаем индекс первого совершенного числа
                }
                if (primeIndex != -1 && perfectIndex != -1) break;
            }

            // Меняем местами найденные числа
            if (primeIndex != -1 && perfectIndex != -1)
            {
                int temp = numbers[primeIndex];
                numbers[primeIndex] = numbers[perfectIndex];
                numbers[perfectIndex] = temp;
            }

            // Формируем строку для вывода
            outputLabel.Content = "Результат: " + string.Join(", ", numbers);
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        private bool IsPerfect(int number)
        {
            if (number < 1) return false;
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0) sum += i;
            }
            return sum == number;
        }
    


        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow secondWindow = new MainWindow();
            secondWindow.Show();
            this.Hide();
        }

        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
