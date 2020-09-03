using System;
using System.Windows;

namespace CS_ASP_008_Challange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            double number1=0, number2=0, total=0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text); 

            total = number1 + number2;

            label.Content = total;        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {

            double number1=0, number2=0, total=0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 - number2;

            label.Content = total;
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {

            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 * number2;

            label.Content = total;
        }

        private void buttonDivision_Click(object sender, RoutedEventArgs e)
        {

            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 / number2;

            label.Content = total;
        }

        private void buttonModulus_Click(object sender, RoutedEventArgs e)
        {

            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 % number2;

            label.Content = total;
        }

        private void buttonClearForm_Click(object sender, RoutedEventArgs e)
        {

            textBox1.Text = "";

            textBox2.Text = "";

            label.Content = "";



        }
    }
}
