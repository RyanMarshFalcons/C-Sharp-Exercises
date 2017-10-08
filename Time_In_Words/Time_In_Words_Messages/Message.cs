using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_In_Words_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Time In Words program where you will enter a time in numerals,\n5:08 for example, and then I will display the time as words, for the example it would be \"eight minutes past five.\" Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterTimeInNumerals()
        {
            Console.Write("Please enter a time in numerals: ");
        }

        public static void TimeEnteredInIncorrectFormat()
        {
            Console.Write("\nSorry but the time must be entered in the correct format (i.e. 7:42). Please\nenter a time in numerals: ");
        }

        public static void TimeEnteredIsInvalid()
        {
            Console.Write("\nSorry but the time entered must be a valid time. The hour must be between 1 and 12 and the minutes must be between 00 and 59. Please enter a time in\nnumerals: ");
        }

        public static void DisplayTimeInWords(string timeInWords)
        {
            Console.WriteLine($"\nYour time in words is {timeInWords}. Press enter to close\nthe program.");
        }
    }
}
