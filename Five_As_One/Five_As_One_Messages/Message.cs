using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five_As_One_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Five As One program where you will enter six numbers and I will\ntell you whether or not it is possible to add five of the numbers together to\nequal the sixth number. Press enter to continue.");
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
            Console.WriteLine("\nCongratulations it is possible to add five of your numbers together to equal thesixth number!!!");
        }

        public static void NotPossible()
        {
            Console.WriteLine("\nUnfortunately it is not possible to add five of your numbers together to equal\nthe sixth number.");
        }
    }
}
