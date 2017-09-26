using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotational_Cipher_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Rotational Cipher program where you will enter a message as a\nstring and then enter the number you want me to rotate the letters in your\nstring by to encode your message. Press enter to continue.");
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

        public static void InputNumber()
        {
            Console.Write("\nPlease enter the number of letters you want me to rotate your message by: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the number of letters\nyou want me to rotate your message by: ");
        }

        public static void OutOfRange(string input)
        {
            Console.Write($"\nSorry but {input} is out of range. Your number must be at least 1 and no more\nthan 25. Please enter the number of letters you want me to rotate your message\nby: ");
        }

        public static void DisplayEncryptedMessage(string newMessage)
        {
            Console.WriteLine($"\nYour message has been encrypted and now reads as:\n{newMessage}\nPress enter to close the program.");
        }
    }
}
