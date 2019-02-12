using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Romeinse_Rekenmachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Dictionary<char, int> romanMap;
        private string[] unitsLetters = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        private string[] tensLetters = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private string[] hundreadsLetters = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private string[] thousendsLetters = { "", "M", "MM", "MMM" };
        private bool newNumber = false;
        private string number1 = "";
        private string number2 = "";
        private string operation = "";
        

        public MainWindow()
        {
            InitializeComponent();

            romanMap = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

            buttonI.Click += NumberButton_Click;
            buttonV.Click += NumberButton_Click;
            buttonX.Click += NumberButton_Click;
            buttonL.Click += NumberButton_Click;
            buttonC.Click += NumberButton_Click;
            buttonD.Click += NumberButton_Click;
            buttonM.Click += NumberButton_Click;
            buttonDivide.Click += OperatorButton_Click;
            buttonTimes.Click += OperatorButton_Click;
            buttonPlus.Click += OperatorButton_Click;
            buttonMinus.Click += OperatorButton_Click;
        }

        private static string ConvertRomanToInteger(string roman)
        {
            int number = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && romanMap[roman[i]] < romanMap[roman[i + 1]])
                {
                    number -= romanMap[roman[i]];
                }
                else
                {
                    number += romanMap[roman[i]];
                }
            }
            return number.ToString();
        }

        private void ButtonBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1.Substring(0, number1.Length - 1);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2.Substring(0, number2.Length - 1);
                textDisplay.Text = number2.ToString();
            }
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = "";
            number2 = "";
            operation = "";
            textDisplay.Text = "";
            newNumber = false;
        }

        private void ButtonClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = "";
            }
            else
            {
                number2 = "";
            }
            textDisplay.Text = "";
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            string tempRomanString = number2;
            number2 = ConvertRomanToInteger(number2);
            if (Convert.ToInt32(number2) > 0 && Convert.ToInt32(number2) <= 3000)
            {
                switch (operation)
                {
                    case "+":
                        number1 = (Convert.ToDouble(number1) + Convert.ToDouble(number2)).ToString();
                        break;

                    case "-":
                        number1 = (Convert.ToDouble(number1) - Convert.ToDouble(number2)).ToString();
                        break;

                    case "*":
                        number1 = (Convert.ToDouble(number1) * Convert.ToDouble(number2)).ToString();
                        break;

                    case "/":
                        number1 = (Convert.ToDouble(number1) / Convert.ToDouble(number2)).ToString();
                        break;

                    default:
                        break;
                }
                int number = Convert.ToInt32(number1);
                number1 = ConvertIntegerToRoman(number);

                textDisplay.Text = number1.ToString();
                number2 = "";
                newNumber = true;
                operation = "";
            }
            else
            {
                MessageBox.Show($"value must be between 0 and 3000");
                number2 = tempRomanString;
            }
        }

        private void ButtonPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (Convert.ToDouble(number1) * -1).ToString();
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (Convert.ToDouble(number2) * -1).ToString();
                textDisplay.Text = number2.ToString();
            }
        }

        private string ConvertIntegerToRoman(int integer)
        {
            // See if it's >= 4000.
            if (integer >= 4000)
            {
                // Use parentheses.
                int thousends = integer / 1000;
                integer %= 1000;
                //return "(" + ConvertIntegerToRoman(thousends) + ")" +
                //    ConvertIntegerToRoman(integer);
                //return $"({ConvertIntegerToRoman(thousends)}{ConvertIntegerToRoman(integer)})";
            }

            // Otherwise process the letters.
            string result = "";

            // Pull out thousands.
            int num;
            num = integer / 1000;
            result += thousendsLetters[num];
            integer %= 1000;

            // Handle hundreds.
            num = integer / 100;
            result += hundreadsLetters[num];
            integer %= 100;

            // Handle tens.
            num = integer / 10;
            result += tensLetters[num];
            integer %= 10;

            // Handle ones.
            result += unitsLetters[integer];

            return result;
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 + Convert.ToString(((Button)sender).Content);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 + Convert.ToString(((Button)sender).Content);
                textDisplay.Text = number2.ToString();
            }
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            string tempRomanString = number1;
            number1 = ConvertRomanToInteger(number1);
            if (Convert.ToInt32(number1) > 0 && Convert.ToInt32(number1) <= 3000)
            {
                switch (Convert.ToString(((Button)sender).Content))
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        operation = Convert.ToString(((Button)sender).Content);
                        textDisplay.Text = operation;
                        newNumber = false;
                        break;

                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show($"value must be between 0 and 3000");
                number1 = tempRomanString;
            }
            
        }
    }
}