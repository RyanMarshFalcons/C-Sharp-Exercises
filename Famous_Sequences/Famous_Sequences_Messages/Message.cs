using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Famous_Sequences_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Famous Sequences Program. These famous sequences of numbers have\nbeen widely used in mathematics for centuries and still have practical uses\ntoday. Press enter to continue.");
            Console.ReadLine();
        }

        public static void SelectSequence()
        {
            Console.WriteLine("Please select one of the following sequences:\nA) Fibonacci Sequence\nB) Lazy Caterer Sequence\nC) Rectangular Sequence\nD) Triangular Sequence");
        }

        public static void NotAValidSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection. Please select one of the\nfollowing sequences:\nA) Fibonacci Sequence\nB) Lazy Caterer Sequence\nC) Rectangular Sequence\nD) Triangular Sequence");
        }

        public static void FibonacciDescription()
        {
            Console.WriteLine("\nThe Fibonacci Sequence is where each number is the sum of the two previous\nnumbers in the sequence. Press enter to view the first forty numbers in the\nFibonacci Sequence.");
            Console.ReadLine();
        }

        public static void LazyCatererDescription()
        {
            Console.WriteLine("\nThe Lazy Caterer Sequence is the maximum number of pieces that can be created\nwith a given number of straight cuts. Press enter to view the first forty\nnumbers in the Lazy Caterer Sequence.");
            Console.ReadLine();
        }

        public static void RectangularDescription()
        {
            Console.WriteLine("\nThe Rectangular Sequence is where each number can form a rectangle where the\nlength is one greater than the width. Press enter to view the first forty\nnumbers in the Rectangular Sequence.");
            Console.ReadLine();
        }

        public static void TriangularDescription()
        {
            Console.WriteLine("\nThe Triangular Sequence is where each number can form an equilateral triangle\nfrom a pattern of dots. Press enter to view the first forty numbers in the\nTriangular Sequence.");
            Console.ReadLine();
        }

        public static void ThankYou(string sequenceName)
        {
            Console.WriteLine($"\nThank you for taking the time to view these numbers in the {sequenceName}\nSequence. Press enter to close the program.");
        }
    }
}
