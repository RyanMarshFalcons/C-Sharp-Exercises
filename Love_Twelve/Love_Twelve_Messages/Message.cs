using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Love_Twelve_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Love Twelve program where I tell you whether or not you love the\nnumber twelve. Press enter to contine.");
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

        public static void DoLoveTwelve()
        {
            Console.WriteLine("\nHooray you love the number twelve!!! Press enter to close the program.");
        }

        public static void DoNotLoveTwelve()
        {
            Console.WriteLine("\nAwwwwww that's too bad. It turns out that you don't love the number twelve afterall. Press enter to close the program.");
        }
    }
}
