using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Calculator program. This calculator is capable of handling\naddition, subtraction, multiplication, and division. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterNumber()
        {
            Console.Write("\nPlease enter a number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input a number: ");
        }

        public static void EnterOperator()
        {
            Console.Write("\nPlease enter one of the following operators + - * / : ");
        }

        public static void NotAnOperator(string input)
        {
            Console.Write($"\nSorry but {input} is not an operator. Please input an operator: ");
        }

        public static void DisplaySum(double num1, double num2, double sum)
        {
            Console.WriteLine($"\nThe sum of {num1} plus {num2} is {sum}\nPress enter to close the program.");
        }

        public static void DisplayDifference(double num1, double num2, double difference)
        {
            Console.WriteLine($"\nThe difference of {num1} minus {num2} is {difference}\nPress enter to close the program.");
        }

        public static void DisplayProduct(double num1, double num2, double product)
        {
            Console.WriteLine($"\nThe product of {num1} times {num2} is {product}\nPress enter to close the program.");
        }

        public static void DisplayQuotient(double num1, double num2, double quotient)
        {
            Console.WriteLine($"\nThe quotient of {num1} divided by {num2} is {quotient}\nPress enter to close the program.");
        }
    }
}
