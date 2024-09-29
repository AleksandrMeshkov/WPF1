using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для Zadacha5.xaml
    /// </summary>
    public partial class Zadacha5 : Window
    {
        public Zadacha5()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int rows = 3; 
            int columns = 4; 

            Random random = new Random();
            int[,] array = new int[rows, columns];

            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(-10, 11);
                }
            }

            
            DataTable dataTable = new DataTable();
            for (int j = 0; j < columns; j++)
            {
                dataTable.Columns.Add($"Column {j + 1}");
            }

            for (int i = 0; i < rows; i++)
            {
                var row = dataTable.NewRow();
                for (int j = 0; j < columns; j++)
                {
                    row[j] = array[i, j];
                }
                dataTable.Rows.Add(row);
            }

           
            dataGrid.ItemsSource = dataTable.DefaultView;

            
            int minValue = array.Cast<int>().Min();
            int maxValue = array.Cast<int>().Max();

           
            minLabel.Content = minValue.ToString();
            maxLabel.Content = maxValue.ToString();
        }
    


        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow secondWindow = new MainWindow();
            secondWindow.Show();
            this.Hide();
        }
    }
}
