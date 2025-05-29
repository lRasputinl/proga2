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

namespace proga2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal firstNumber, drob = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            if ((Field.Text == "0") || (Field.Text == "Ошибка!"))
            {
                Field.Text = "";
            }
            Field.Text += "1";
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            if ((Field.Text == "0") || (Field.Text == "Ошибка!"))
            {
                Field.Text = "";
            }
            Field.Text += "0";

        }

        private void btn_dot_Click(object sender, RoutedEventArgs e)
        {
            if ((Field.Text == "0") || (Field.Text == "Ошибка!") || (Field.Text == ""))
            {
                Field.Text = "";
            }
            else
            {
                int count = Field.Text.Count(c => c == ',');
                drob = Convert.ToDecimal(Field.Text);
                if (count >= 1)
                {
                    Field.Text = drob.ToString();
                }
                else
                { 
                    Field.Text += ",";
                }
            }
        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            decimal secondNumber;
            if (decimal.TryParse(Field.Text, out secondNumber))
            {
                switch (operation)
                {
                    case "+":
                        Field.Text = (firstNumber + secondNumber).ToString();
                        break;
                    case "-":
                        Field.Text = (firstNumber - secondNumber).ToString();
                        break;
                    case "*":
                        Field.Text = (firstNumber * secondNumber).ToString();
                        break;
                    case "/":
                        if (secondNumber != 0)
                        { 
                            Field.Text = (firstNumber / secondNumber).ToString();
                        }
                        else
                        {
                            Field.Text = "Ошибка!";
                        }
                        break;
                }
            }
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            if ((Field.Text == "0") || (Field.Text == "Ошибка!"))
            {
                Field.Text = "";
            }
            Field.Text += "2";
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if ((Field.Text == "0") || (Field.Text == "Ошибка!"))
            {
                Field.Text = "";
            }
            Field.Text += "3";
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Field.Text))
            {
                firstNumber = decimal.Parse(Field.Text);
                operation = "+";
                Field.Text = "";
            }
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if ((Field.Text == "0") || (Field.Text == "Ошибка!"))
            {
                Field.Text = "";
            }
            Field.Text += "4";
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if ((Field.Text == "0") || (Field.Text == "Ошибка!"))
            {
                Field.Text = "";
            }
            Field.Text += "5";
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if ((Field.Text == "0") || (Field.Text == "Ошибка!"))
            {
                Field.Text = "";
            }
            Field.Text += "6";
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Field.Text))
            {
                firstNumber = decimal.Parse(Field.Text);
                operation = "-";
                Field.Text = "";
            }
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if ((Field.Text == "0") || (Field.Text == "Ошибка!"))
            {
                Field.Text = "";
            }
            Field.Text += "7";
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if ((Field.Text == "0") || (Field.Text == "Ошибка!"))
            {
                Field.Text = "";
            }
            Field.Text += "8";
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if ((Field.Text == "0") || (Field.Text == "Ошибка!"))
            {
                Field.Text = "";
            }
            Field.Text += "9";
        }

        private void btn_multiply_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Field.Text))
            {
                firstNumber = decimal.Parse(Field.Text);
                operation = "*";
                Field.Text = "";
            }
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            Field.Text = "0";
            firstNumber = 0;
            operation = "";
        }

        private void btn_procent_Click(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(Field.Text, out decimal number))
            {
                Field.Text = (number / 100).ToString();
            }
        }

        private void btn_changeSign_Click(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(Field.Text, out decimal number))
            {
                Field.Text = (-number).ToString();
            }
        }

        private void btn_division_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Field.Text))
            {
                firstNumber = decimal.Parse(Field.Text);
                operation = "/";
                Field.Text = "";
            }
        }
    }
}
