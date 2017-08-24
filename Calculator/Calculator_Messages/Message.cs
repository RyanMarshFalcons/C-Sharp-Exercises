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
            Console.WriteLine("Welcome to my Calculator program where I will give you the solutions to basic\nmath problems. Press enter to continue.");
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

        public static void SelectOperator()
        {
            Console.WriteLine("\nPlease select one of the following operators:\nA) Plus\nB) Minus\nC) Times\nD) Divided By\nE) Squared\nF) Cubed\nG) Tesseracted\nH) Square Root");
        }

        public static void NotAValidSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection. Please select one of the\nfollowing operators:\nA) Plus\nB) Minus\nC) Times\nD) Divided By\nE) Squared\nF) Cubed\nG) Tesseracted\nH) Square Root");
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

        public static void DisplayNumberSquared(double num, double numSquared)
        {
            Console.WriteLine($"\n{num} squared is {numSquared}\nPress enter to close the program.");
        }

        public static void DisplayNumberCubed(double num, double numCubed)
        {
            Console.WriteLine($"\n{num} cubed is {numCubed}\nPress enter to close the program.");
        }

        public static void DisplayNumberTesseracted(double num, double numTesseracted)
        {
            Console.WriteLine($"\n{num} tesseracted is {numTesseracted}\nPress enter to close the program.");
        }

        public static void DisplaySquareRootOfNum(double num, double sqrRootOfNum)
        {
            Console.WriteLine($"\nThe square root of {num} is {sqrRootOfNum}\nPress enter to close the program.");
        }
    }
}
