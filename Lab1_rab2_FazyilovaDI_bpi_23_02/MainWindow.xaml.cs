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

namespace Lab1_rab2_FazyilovaDI_bpi_23_02
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
        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsDigit(c) && e.Text != "." && e.Text != ",")
                {
                    e.Handled = true;
                    return;
                }
            }
        }
        private void textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) e.Handled = true;
        }
        private void compute_Click (object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(xTextBox.Text))
                {
                    MessageBox.Show("введите число");
                    return;
                }
              //  BaseClass function = null;
                double res;
                switch (TrigFun.SelectedIndex)
                {
                    case 0:
                        Secans function1 = new Secans(); //конструктор по умолчанию (наследника)
                        res = function1.Calculate(double.Parse(xTextBox.Text) * Math.PI / 180);
                        break;
                    case 1:
                        Cosecans function2 = new Cosecans();
                        res = function2.Calculate(double.Parse(xTextBox.Text) * Math.PI / 180);
                        break;
                    case 2:
                        Cotangens function3 = new Cotangens();
                        res = function3.Calculate(double.Parse(xTextBox.Text), true);
                        break;
                    default: return;
                }
               // double res = function.Calculate(double.Parse(xTextBox.Text) * Math.PI / 180);
                resultTextBox.Text = res.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
