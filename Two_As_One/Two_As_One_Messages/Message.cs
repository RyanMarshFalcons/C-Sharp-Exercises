using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_As_One_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Two As One program where you will enter three numbers and I will\ntell you whether or not it is possible to add two of the numbers together to\nequal the third number. Press enter to continue.");
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

        public static void IsPossible()
        {
            Console.WriteLine("\nCongratulations it is possible to add two of your numbers together to equal the third number!!!");
        }

        public static void NotPossible()
        {
            Console.WriteLine("\nUnfortunately it is not possible to add two of your numbers together to equal\nthe third number.");
        }
    }
}
