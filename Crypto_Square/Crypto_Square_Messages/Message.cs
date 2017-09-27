using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Square_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Crypto Square program where you will enter a message as a string\nand then I will encode it using square code. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserString()
        {
            Console.Write("Enter the message you wish for me to encode: ");
        }

        public static void TooShort()
        {
            Console.Write("\nSorry but you must input at least four characters to create a valid message.\nPlease enter the message you wish for me to encode: ");
        }

        public static void HasNoLetters()
        {
            Console.Write("\nSorry but you must include at least one letter to create a valid message. Pleaseenter the message you wish for me to encode: ");
        }

        public static void DisplayCryptoSquare(List<string> rowsOfText)
        {
            Console.WriteLine("\nYour message as a crypto square is:");
            foreach (var row in rowsOfText)
            {
                Console.WriteLine(row);
            }
            Console.WriteLine("\nPress enter to close the program.");
        }
    }
}
