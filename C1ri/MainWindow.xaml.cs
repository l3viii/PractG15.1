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
using Gytt1;

namespace C1ri
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дроздов Г. ИСП-34", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CountClick(object sender, RoutedEventArgs e)
        {

            int value;
            bool f = Int32.TryParse(Nperem.Text, out value);
            if (f == true)
            {
                var finding = Practice.ProductEvenWithOut(value);
                AllNumbers.Text = finding.allNumbers.ToString();
                Result.Text = finding.calculations;
            }
            else
            {
                MessageBox.Show("Введите корректное целочисленное значение!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);    
            }
        }
    }
}
