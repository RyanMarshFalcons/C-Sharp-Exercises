using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangular_Sequence_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Triangular Sequence Program. The Triangular sequence is where eachnumber can form an equilateral triangle. I have compiled a list of all the\nnumbers in the Triangular sequence that I can so that they are still viewable toyou. Press enter to view them.");
            Console.ReadLine();
        }

        public static void ThankYou()
        {
            Console.WriteLine("\nThank you for taking the time to view these numbers in the Triangular Sequence.\nPress enter to end the program.");
        }
    }
}
