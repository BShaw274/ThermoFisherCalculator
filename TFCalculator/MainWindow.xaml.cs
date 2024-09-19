using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TFCalculator
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

        CalculatorObject cal = new CalculatorObject();

        //All button controls
        private void Button_Click_Addition(object sender, RoutedEventArgs e)
        {
            cal.setNums(double.Parse(Message1.Text));
            cal.setOperand(Operation.addition);
            Message1.Text = "";
        }

        private void Button_Click_Subtraction(object sender, RoutedEventArgs e)
        {
            cal.setNums(double.Parse(Message1.Text));
            cal.setOperand(Operation.subtraction);
            Message1.Text = "";
        }

        private void Button_Click_Multiplication(object sender, RoutedEventArgs e)
        {
            cal.setNums(double.Parse(Message1.Text));
            cal.setOperand(Operation.multiplication);
            Message1.Text = "";
        }

        private void Button_Click_Division(object sender, RoutedEventArgs e)
        {
            cal.setNums(double.Parse(Message1.Text));
            cal.setOperand(Operation.division);
            Message1.Text = "";
        }
        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            cal.nums.Clear();
            Message1.Text = "";
        }
        private void Button_Click_Equals(object sender, RoutedEventArgs e)
        {
            cal.setNums(double.Parse(Message1.Text));
            Message1.Text = cal.results();
        }
        private void Button_Click_Flip(object sender, RoutedEventArgs e)
        {
            double num = double.Parse(Message1.Text);
            num = num * (-1);
            Message1.Text = num.ToString();
        }
        //Number buttons

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            Message1.Text += "0";
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Message1.Text += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Message1.Text += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Message1.Text += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Message1.Text += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Message1.Text += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Message1.Text += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Message1.Text += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Message1.Text += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Message1.Text += "9";
        }

        private void Button_Click_Dot(object sender, RoutedEventArgs e)
        {
            if(!Message1.Text.Contains("."))
            {
                Message1.Text += ".";
            }
            
        }
    }
}