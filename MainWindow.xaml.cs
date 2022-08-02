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

namespace CalculatorApplication
{
    // Class for methods used to calculate.
    public class Engine
    {
        Interface obj = new Interface();
        private double operandA;
        private double operandB;
        private char symbol;

        public Engine() { }

        /** 
         * Constructor.
         * @param operandA: The digit furthest to the left.
         * @param operandB: The digit furthest to the right.
         * @param symbol: The operator between operands.
         * **/
        private Engine(int operandA, int operandB, char symbol)
        {
            this.operandA = operandA;
            this.operandB = operandB;
            this.symbol = symbol;
        }

        // Calculate the operands and operator using infix order.
        public string Calculate_Expression(string str)
        {
            Engine expr;
            double result = 0.0;

            // Creating new object of display's input.
            try
            {
                // Check length of expression is no more than 2 single digits and 1 operator.
                if (str.Length > 3) { return "Please use single digits"; }
                if (str[1] == '/' && str[2] == '0') { return "ERR: Division by zero"; } 
                expr = new Engine(int.Parse(str[0].ToString()), int.Parse(str[2].ToString()), str[1]);
            }

            // The expression is not in infix notation.
            catch
            {
                Console.WriteLine($"Invalid input given. Please use infix notation with single digit operands \nExample of input: 2+4");
                return "ERR: Expected form (a+b)";
            }

            if (expr.symbol == '+')
            {
                result = expr.operandA + expr.operandB;
            }

            else if (expr.symbol == '-')
            {
                result = expr.operandA - expr.operandB;
            }

            else if (expr.symbol == '*')
            {
                result = expr.operandA * expr.operandB;
            }

            else if (expr.symbol == '/')
            {
                result = expr.operandA / expr.operandB;
            }

            // Incase any other characters are entered.
            else
            {
                obj.display.Content = "Valid symbols: (+ - * =).";
            }

            return result.ToString();
        }
    }

    // Class for methods used in the display.
    public partial class Interface : Window
    {
        private string expr;

        public Interface()
        {
            InitializeComponent();
        }

        // Clear the calculator's display.
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            expr = "";
            display.Content = "";
        }

        // Turn the calculator on (enabling all buttons to be pressed).
        private void On_Click(object sender, RoutedEventArgs e)
        {
            display.Content = "";
            add.IsEnabled = true;
            subtract.IsEnabled = true;
            multiply.IsEnabled = true;
            divide.IsEnabled = true;
            equal.IsEnabled = true;
            clear.IsEnabled = true;
            one.IsEnabled = true;
            two.IsEnabled = true;
            three.IsEnabled = true;
            four.IsEnabled = true;
            five.IsEnabled = true;
            six.IsEnabled = true;
            seven.IsEnabled = true;
            eight.IsEnabled = true;
            nine.IsEnabled = true;
            zero.IsEnabled = true;
        }

        // End the program.
        private void Off_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        // Return the result of the calculation.
        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            Engine obj = new Engine();
            display.Content = obj.Calculate_Expression(expr);
            expr = "";
        }

        // Selections of operators.
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            expr += "+";
            display.Content = "";
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            expr += "-";
            display.Content = "";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            expr += "*";
            display.Content = "";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            expr += "/";
            display.Content = "";
        }

        // Output chosen digit onto screen.
        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            expr += "0";
            display.Content += "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            expr += "1";
            display.Content += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            expr += "2";
            display.Content += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            expr += "3";
            display.Content += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            expr += "4";
            display.Content += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            expr += "5";
            display.Content += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            expr += "6";
            display.Content += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            expr += "7";
            display.Content += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            expr += "8";
            display.Content += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            expr += "9";
            display.Content += "9";
        }

        private void Button_Click()
        {

        }
    }
}