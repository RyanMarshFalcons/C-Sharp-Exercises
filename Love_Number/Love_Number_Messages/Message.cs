using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Love_Number_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Love Number program where you enter a number and then I tell you\nwhether or not you love that number. Press enter to contine.");
            Console.ReadLine();
        }

        public static void EnterNumber(string firstSecondLove)
        {
            Console.Write($"\nPlease enter the {firstSecondLove} number: ");
        }

        public static void RequestTwoMoreNums(int loveNumber)
        {
            Console.WriteLine($"\nNow I will ask you to input two more numbers to determine whether or not you\nlove the number {loveNumber}. Press enter to continue.");
            Console.ReadLine();
        }

        public static void NotANumber(string input, string firstSecondLove)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input the {firstSecondLove} number: ");
        }

        public static void DoLoveNumber(int loveNumber)
        {
            Console.WriteLine($"\nHooray you love the number {loveNumber}!!! Press enter to close the program.");
        }

        public static void DoNotLoveNumber(int loveNumber)
        {
            Console.WriteLine($"\nAwwwwwwww that's too bad. It turns out that you don't love the number {loveNumber}\nafter all. Press enter to close the program.");
        }
    }
}
