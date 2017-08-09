using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Sequence_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Square Sequence Program. The Square sequence is where each number is a square of a number. I have compiled a list of all the numbers in the Squaresequence that I can so that they are still viewable to you. Press enter to view them.");
            Console.ReadLine();
        }

        public static void ThankYou()
        {
            Console.WriteLine("\nThank you for taking the time to view these numbers in the Square Sequence.\nPress enter to end the program.");
        }
    }
}
