using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Fibonacci Sequence Program. The Fibonacci sequence is where each\nnumber is the sum of the two previous numbers in the sequence. I have compiled alist of as many numbers in the Fibonacci sequence that are calculatable using\nthe integer class. Press enter to view them.");
            Console.ReadLine();
        }

        public static void ThankYou()
        {
            Console.WriteLine("\nThank you for taking the time to view these numbers in the Fibonacci Sequence.\nPress enter to end the program.");
        }
    }
}
