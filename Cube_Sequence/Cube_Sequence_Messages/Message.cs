using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Sequence_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Cube Sequence Program. The Cube sequence is where each number is acube of a number. I have compiled a list of all the numbers in the Cube sequencethat I can so that they are still viewable to you. Press enter to view them.");
            Console.ReadLine();
        }

        public static void ThankYou()
        {
            Console.WriteLine("\nThank you for taking the time to view these numbers in the Cube Sequence.\nPress enter to end the program.");
        }
    }
}
