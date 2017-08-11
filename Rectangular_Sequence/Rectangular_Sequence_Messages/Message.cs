using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangular_Sequence_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Rectangular Sequence Program. The Rectangular sequence is where\neach number can form a rectangle where the length is one greater than the width.I have compiled a list of all the numbers in the Rectangular sequence that I canso that they are still viewable to you.Press enter to view them.");
            Console.ReadLine();
        }

        public static void ThankYou()
        {
            Console.WriteLine("\nThank you for taking the time to view these numbers in the Rectangular Sequence.\nPress enter to end the program.");
        }

    }
}
