using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_As_One_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Three As One program where you will enter four numbers and I will\ntell you whether or not it is possible to add three of the numbers together to\nequal the fourth number. Press enter to continue.");
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
            Console.WriteLine("\nCongratulations it is possible to add three of your numbers together to equal\nthe fourth number!!!");
        }

        public static void NotPossible()
        {
            Console.WriteLine("\nUnfortunately it is not possible to add three of your numbers together to equal\nthe fourth number.");
        }
    }
}
