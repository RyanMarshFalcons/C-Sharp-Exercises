using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atbash_Cipher_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Atbash Cipher program where you will enter a message and I will\nencode your message using the ancient atbash cipher. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserString()
        {
            Console.Write("Enter the message you wish for me to encode: ");
        }

        public static void TooShort()
        {
            Console.Write("\nSorry but you must input at least one character to create a valid message.\nPlease enter the message you wish for me to encode: ");
        }

        public static void HasNoLetters()
        {
            Console.Write("\nSorry but you must include at least one letter to create a valid message. Pleaseenter the message you wish for me to encode: ");
        }

        public static void DisplayEncryptedMessage(string newMessage)
        {
            Console.WriteLine($"\nYour message has been encrypted and now reads as:\n{newMessage}\nPress enter to close the program.");
        }
    }
}
