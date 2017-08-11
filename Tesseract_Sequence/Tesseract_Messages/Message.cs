using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesseract_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Tesseract Sequence Program. The Tesseract sequence is where each\nnumber is a tesseract of a number. I have compiled alist of as many numbers in\nthe Tesseract sequence that are calculatable using the integer class. Press\nenter to view them.");
            Console.ReadLine();
        }

        public static void ThankYou()
        {
            Console.WriteLine("\nThank you for taking the time to view these numbers in the Tesseract Sequence.\nPress enter to end the program.");
        }

    }
}
