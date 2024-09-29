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
    /// Логика взаимодействия для Zadacha3.xaml
    /// </summary>
    public partial class Zadacha3 : Window
    {
        public Zadacha3()
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
        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void outputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string[] parts = inputTextBox.Text.Split(',');

            
            if (parts.Length < 10)
            {
                outputLabel.Content = "Массив должен содержать как минимум 10 элементов.";
                return;
            }

            
            for (int i = 1; i < parts.Length; i++)
            {
                if (int.Parse(parts[0]) < int.Parse(parts[i]) && int.Parse(parts[i]) < int.Parse(parts[9]))
                {
                    outputLabel.Content = (i + 1).ToString(); 
                    return;
                }
            }

            
            outputLabel.Content = "0";
        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow secondWindow = new MainWindow();
            secondWindow.Show();
            this.Hide();
        }
    }
    
}
