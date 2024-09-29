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
    /// Логика взаимодействия для Zadacha1.xaml
    /// </summary>
    public partial class Zadacha1 : Window
    {
        public Zadacha1()
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
    

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var input = inputTextBox.Text;
            var repeatedDigits = new string(input.Where(char.IsDigit)
                .GroupBy(c => c)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToArray());
            outputTextBox.Text = repeatedDigits.Length > 0 ? repeatedDigits : "Нет повторяющихся цифр";
        }

        private void outputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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
