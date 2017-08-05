using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSum_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my String Sum program where you enter text and then I give you the sum of all of the number characters of your input. Press enter to\ncontinue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please input as much text as you please: ");
        }

        public static void NoEmptyStrings()
        {
            Console.Write("\nYou must input at least one character for me to be able find the sum of your\nnumber characters. Please try again: ");
        }

        public static void DisplayResults(int count, int sum)
        {
            Console.WriteLine($"\nThe sum of the {count} number characters that you input is {sum}");
        }
    }
}
