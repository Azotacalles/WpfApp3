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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float number1;
        float number2;
        char symbol;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LabelNumbers.Content += ((Button)sender).Content.ToString();
        }

        private void Button_Click_Sum(object sender, RoutedEventArgs e)
        {
            number1 = Int32.Parse(LabelNumbers.Content.ToString());
            symbol = '+';
            LabelNumbers.Content = "";
        }

        private void Button_Click_Res(object sender, RoutedEventArgs e)
        {
            number2 = Int32.Parse(LabelNumbers.Content.ToString());
            switch(symbol)
            {
                case '+':
                    LabelNumbers.Content = (number1 + number2).ToString();
                    break;
            }
        }
    }
}
