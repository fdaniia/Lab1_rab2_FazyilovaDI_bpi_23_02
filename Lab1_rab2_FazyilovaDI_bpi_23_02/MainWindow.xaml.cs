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
        private bool isDarkTheme = false;
        public MainWindow()
        {
            InitializeComponent();
            ApplyLightTheme();
        }
        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsDigit(c)  && e.Text != ",")
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
                double derivativeRes;
                switch (TrigFun.SelectedIndex)
                {
                    case 0:
                        Secans function1 = new Secans(double.Parse(xTextBox.Text) * Math.PI / 180); //конструктор по умолчанию (наследника)
                        res = function1.Calculate(double.Parse(xTextBox.Text) * Math.PI / 180);
                        derivativeRes = function1.GetDerivative(double.Parse(xTextBox.Text) * Math.PI / 180);
                        break;
                    case 1:
                        Cosecans function2 = new Cosecans(double.Parse(xTextBox.Text) * Math.PI / 180);
                        res = function2.Calculate(double.Parse(xTextBox.Text) * Math.PI / 180);
                        derivativeRes = function2.GetDerivative(double.Parse(xTextBox.Text) * Math.PI / 180);
                        break;
                    case 2:
                        Cotangens function3 = new Cotangens(double.Parse(xTextBox.Text) * Math.PI / 180);
                        if (xTextBox.Text.Contains(","))
                        {
                            res = function3.Calculate(double.Parse(xTextBox.Text), false);
                            derivativeRes = function3.GetDerivative(double.Parse(xTextBox.Text) * Math.PI / 180);
                        }
                        else
                        {
                            res = function3.Calculate(double.Parse(xTextBox.Text) * Math.PI / 180);
                            derivativeRes = function3.GetDerivative(double.Parse(xTextBox.Text) * Math.PI / 180);
                        }
                            // res = function3.Calculate(double.Parse(xTextBox.Text), true);
                            break;
                    default: return;
                }
               // double res = function.Calculate(double.Parse(xTextBox.Text) * Math.PI / 180);
                resultTextBox.Text = res.ToString();
                derivativeTextBox.Text = derivativeRes.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ThemeToggleButton_Click(object sender, RoutedEventArgs e)
        {
            isDarkTheme = !isDarkTheme;
            if (isDarkTheme) ApplyDarkTheme();
            else { ApplyLightTheme(); }
        }
        private void ApplyLightTheme()
        {
            var uri = new Uri("LightTheme.xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            ThemeToggleButton.Content = "темная тема";
        }

        private void ApplyDarkTheme()
        {
            var uri = new Uri("DarkTheme.xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            ThemeToggleButton.Content = "светлая тема";
        }

        private void TrigFun_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
