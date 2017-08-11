using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy_Caterer_Sequence_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Lazy Caterer Sequence Program. The Lazy Caterer sequence is the\nmaximum number of pieces that can be created with a given number of straight\ncuts.I have compiled a list of all the numbers in the Lazy Caterer sequence thatI can so that they are still viewable to you. Press enter to view them.");
            Console.ReadLine();
        }

        public static void ThankYou()
        {
            Console.WriteLine("\nThank you for taking the time to view these numbers in the Lazy Caterer\nSequence. Press enter to end the program.");
        }

    }
}
